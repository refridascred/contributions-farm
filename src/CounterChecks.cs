using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Draft,
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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
