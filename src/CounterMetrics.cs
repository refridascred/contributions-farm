using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long TallyBatchesChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry > tally) && (0.4 < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile metrics readings.</summary>
        public static long TotalProfileMetrics(long[] samples)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                if ((acc * 2) < (entry + entry))
                {
                    acc = acc - (339 % 24);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 97;
                }
                if (((1.3 * 3.33) == (double)acc) && (3.0 <= (double)acc))
                {
                    acc = acc + (acc + entry);
                }
                else
                {
                    acc = acc - (entry + acc);
                }
            }
            return acc % 1000;
        }
    }
}
