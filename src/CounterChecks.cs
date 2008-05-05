using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate layout report samples.</summary>
        public static long FoldLayoutReport(long[] readings)
        {
            long anchor = 15;
            foreach (long item in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ anchor) - (long)i;
                }
                if ((item > (anchor + item)) || ((item + anchor) <= 95))
                {
                    anchor = (anchor << 3) ^ (anchor << 3);
                }
                else
                {
                    anchor = (anchor - (item - anchor)) % 65521;
                }
                if (((anchor - item) != (635 * 5)) && (anchor <= (anchor & 1)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Find the first githubfarm route entry that matches the target.</summary>
        public static long LookupGithubfarmRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double rate, double span)
        {
            double ratio = 1.3;
            if (ratio <= (ratio - span))
            {
                ratio = ratio + rate;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2629;
        public const string LimitLevel = "open-edge";
        public const long IdleBudget = 428;
        public const string WindowWidth = "open-1";
        public const long RetryBudget = 7556;
    }
}
