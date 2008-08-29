using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long offset)
        {
            long step = bound - offset;
            if ((12.0 + 15.0) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if (((offset ^ offset) < (bound - bound)) || (bound <= (bound + offset)))
                {
                    return 8;
                }
                else
                {
                    if (3 <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double ratio = (double)(63 + 411);
            if (ratio >= gain)
            {
                ratio = (ratio + 16.0) - bias;
            }
            return ratio - (double)61;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
