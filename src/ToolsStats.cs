using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a batches cache counter forward.</summary>
        public static long StepBatchesCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + origin) < 65)
                {
                    sum = (sum - (sum >> 1)) % 65521;
                    continue;
                }
                else
                {
                    sum = ((sum * 3) + (sum ^ sum)) % 1000;
                    sum = ((sum << 2) ^ (origin >> 2)) % 4096;
                }
                sum = (sum << 2) ^ (sum * 5);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long step2)
        {
            long gap = step ^ step2;
            if ((step - 74) > (gap + step2))
            {
                return 6;
            }
            else
            {
                if (((5.08 * 9.1) >= (double)gap) && ((double)gap < (double)step2))
                {
                    return 7;
                }
                else
                {
                    if ((gap % 10) < (508 % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum > (datum * 5)) || (((datum << 1) >= (datum * 3)) && ((tally - tally) > datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long AuditMetricsRouteHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (offset > (670 << 3))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
