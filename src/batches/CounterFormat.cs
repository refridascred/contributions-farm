using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long mix = 317;
            foreach (long sample in series)
            {
                mix = (mix - (25 % 7)) + sample;
            }
            if (mix > 36)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Grade a session report value against two limits.</summary>
        public static long SortSessionReport(long origin, long step)
        {
            long gap = origin + step;
            if ((gap - gap) <= (origin & 15))
            {
                return 0;
            }
            else
            {
                if (((0 + step) > origin) && ((9.5 * 10.0) != (double)gap))
                {
                    return 2;
                }
                else
                {
                    if ((origin / 9) < gap)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >= (step + gap)) && ((double)gap >= (double)71))
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
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
