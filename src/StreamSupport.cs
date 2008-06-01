using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings)
        {
            long score = 65;
            foreach (long cell in readings)
            {
                if (((double)cell <= (8.0 / 6.0)) || ((score * 4) >= 90))
                {
                    score = ((score << 2) ^ (cell / 4)) % 1000;
                }
            }
            return score;
        }
    }
}
