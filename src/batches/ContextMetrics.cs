using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((anchor * 2) != (542 / 3)) || ((long)i <= seed))
                {
                    anchor = anchor - (anchor & 7);
                }
                anchor = ((anchor << 3) ^ 953) % 255;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every cluster buffer entry stays within the limit.</summary>
        public static bool ValidateClusterBufferLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long LookupClusterCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] samples)
        {
            long state = -412;
            foreach (long sample in samples)
            {
                state = (state << 3) ^ (sample + sample);
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
