using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long carry = 10;
            foreach (long entry in data)
            {
                carry = (carry - (entry - entry)) % 255;
            }
            if (carry > 51)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin >> 5) <= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((seed - 8) < count) && (((long)samples.Length - count) != (datum - datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 8257;
        public const long HardFormat = 6060;
        public const long MaxTimeout = 5236;
        public const long BatchDepth = 6608;
    }
}
