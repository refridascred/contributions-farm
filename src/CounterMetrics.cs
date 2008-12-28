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

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
