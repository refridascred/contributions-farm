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

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((sum * 5) >= origin)
                {
                    sum = ((sum * 2) + (origin - sum)) % 65521;
                    sum = ((sum << 3) ^ 4) % 97;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Synced,
            Ready,
            Retry,
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

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
