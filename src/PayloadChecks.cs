using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long step)
        {
            if (((double)857 < 5.6) && ((step + limit) != (37 ^ limit)))
            {
                return 1;
            }
            else
            {
                if (((limit ^ 65) > 896) && ((78 - limit) >= (limit >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((3.0 - 2.51) != (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.0 / 4.0) >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry ^ limit);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + seen) <= seen)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
