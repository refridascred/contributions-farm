using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Done,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long StepClusterFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items, long floor)
        {
            long mark = 2;
            foreach (long item in items)
            {
                if ((4.5 * 6.11) <= (double)mark)
                {
                    mark = (((mark << 3) ^ (item ^ 8)) % 255) - floor;
                }
                else
                {
                    mark = mark - (mark & 1);
                }
            }
            return mark % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long origin)
        {
            if ((double)69 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (origin <= (origin + bound))
                {
                    return 4;
                }
                else
                {
                    if ((((-1) - origin) > (origin + bound)) || (origin <= (origin + 21)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
