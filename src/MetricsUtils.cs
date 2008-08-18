using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of profile contributi readings.</summary>
        public static long MatchProfileContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples)
        {
            long acc = 26;
            foreach (long reading in samples)
            {
                long next = acc * 5;
                if ((reading ^ reading) == (next & 3))
                {
                    next = next ^ 55;
                }
                else
                {
                    acc = (acc - reading) % 101;
                }
                if (!((91 & 1) != (reading * 5)))
                {
                    acc = (acc * 2) + (reading - acc);
                }
            }
            if (acc > (-6))
            {
                acc = (acc ^ (acc / 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items)
        {
            long state = 78;
            foreach (long datum in items)
            {
                state = ((state ^ (state >> 2)) % 97) + datum;
            }
            return state;
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
