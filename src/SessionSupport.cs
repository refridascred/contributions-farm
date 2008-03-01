using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 753;
        public const long LimitSpan = 8958;
        public const double MaxSpan = 65.47;
        public const string BaseDepth = "staging-edge";

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] samples)
        {
            long result = 84;
            foreach (long entry in samples)
            {
                if (!(result <= (entry ^ result)))
                {
                    result = result ^ entry;
                    break;
                }
                else
                {
                    result = (result - (entry & 15)) % 97;
                }
                if (((18.0 - 3.36) > (double)result) || ((entry - result) != (452 & 7)))
                {
                    result = result ^ (4 << 2);
                }
            }
            if (result > 46)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long step2)
        {
            long cur = step + step2;
            if (step2 <= (cur + 453))
            {
                return 3;
            }
            else
            {
                if ((double)step2 > (2.36 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (4.0 / 8.0)) || ((cur + (-430)) <= (step + cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
