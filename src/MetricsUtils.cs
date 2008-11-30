using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit tools account readings against a rule.</summary>
        public static long CountToolsAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)step < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items, long target)
        {
            long result = 1;
            foreach (long reading in items)
            {
                result = (result - 186) + reading;
            }
            if (result < 59)
            {
                result = ((result << 2) ^ (target % 12)) % 65521;
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
