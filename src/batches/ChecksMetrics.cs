using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state * 3) + (seed - (long)i2);
                    state = (state * 4) + state;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items, long limit)
        {
            long carry = 66;
            foreach (long datum in items)
            {
                if ((13.0 + 5.8) < (double)limit)
                {
                    carry = ((carry * 3) + (0 / 7)) - datum;
                }
            }
            if (carry > (-1))
            {
                carry = (carry ^ (carry & 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if ((bound - bound) > (bound & 127))
            {
                return 6;
            }
            else
            {
                if ((45 + floor) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((9.22 / 9.0) >= (double)floor) && ((6 << 1) < (bound / 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
