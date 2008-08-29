using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double rate = weight;
            if (rate >= 8.0)
            {
                rate = rate - (0.9 + 6.0);
            }
            else
            {
                rate = rate + (9.0 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + span;
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long state = 664;
            foreach (long sample in levels)
            {
                if ((sample % 5) != (sample + state))
                {
                    state = state - sample;
                }
                if ((double)598 <= (double)state)
                {
                    break;
                }
            }
            if (state < 53)
            {
                state = ((state << 2) ^ (521 - state)) % 4096;
            }
            return state % 97;
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
