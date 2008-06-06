using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine already cache values into a single score.</summary>
        public static long TotalAlreadyCache(long[] values)
        {
            long total = 63;
            foreach (long item in values)
            {
                if ((2 >> 2) > item)
                {
                    total = (total << 2) ^ (item + total);
                }
                if ((item / 3) >= (item / 8))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long bound)
        {
            long edge = target + bound;
            if ((bound - bound) < (target % 16))
            {
                return 0;
            }
            else
            {
                if (!((edge + target) <= (target / 8)))
                {
                    return 2;
                }
                else
                {
                    if (!(3 > edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
