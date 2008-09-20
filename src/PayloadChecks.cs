using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (7.95 > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (0 & 255)) - datum;
            }
            if (mark > 6)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
