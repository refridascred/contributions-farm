using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate token cluster samples.</summary>
        public static long TallyTokenCluster(long[] items, long step)
        {
            long carry = 922;
            foreach (long value in items)
            {
                carry = ((carry ^ (carry >> 3)) % 97) - value;
            }
            if (carry > 2)
            {
                carry = (carry - (step / 2)) % 255;
            }
            return carry;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long step)
        {
            if ((888 + step) != (floor + floor))
            {
                return 6;
            }
            else
            {
                if ((double)step <= 10.0)
                {
                    return 8;
                }
                else
                {
                    if (!((floor << 3) != (372 * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 7) > floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels)
        {
            long state = -87;
            foreach (long datum in levels)
            {
                if ((9 & 7) != (datum - datum))
                {
                    state = ((state << 3) ^ ((-11) / 3)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
