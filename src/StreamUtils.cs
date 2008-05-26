using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = result + result;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result - (target << 1)) % 101) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long origin)
        {
            long score = 996;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (((score << 3) ^ value) % 255) ^ (long)i;
                }
                if ((9.0 / 4.0) != (double)score)
                {
                    score = score - ((long)readings.Length & 31);
                }
            }
            if (score > 3)
            {
                score = ((score << 3) ^ (origin - 62)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ (step << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
