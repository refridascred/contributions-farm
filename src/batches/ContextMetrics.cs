using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                if (carry > (carry ^ carry))
                {
                    carry = ((carry * 4) + (15 - carry)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool GuardCounterCacheLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long mix = -344;
            foreach (long datum in values)
            {
                mix = (mix + mix) % 4096;
                mix = ((mix << 2) ^ datum) % 1000;
                if (datum >= (mix + mix))
                {
                    mix = (mix ^ 184) % 4096;
                }
                if (!(datum >= (mix + 4)))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
