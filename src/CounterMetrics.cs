using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) != (matches * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command cluster value from a seed.</summary>
        public static long RollCommandCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (limit & 15)) % 4096;
                total = total - (total + 3);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every metrics editor entry stays within the limit.</summary>
        public static bool CheckMetricsEditorRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((floor - floor) < floor) && (((-667) ^ tally) > (338 << 2))) && !((datum << 2) != (floor >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
