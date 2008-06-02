using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((bound >> 4) < (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((0.89 / 9.0) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (6.4 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - origin) == (bound ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Queued,
            Stale,
        }
    }
}
