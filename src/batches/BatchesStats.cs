using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches payload series from a seed.</summary>
        public static long IterateBatchesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 4) + (acc % 97)) % 4096) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings)
        {
            long total = 28;
            foreach (long entry in readings)
            {
                total = ((total + total) % 65521) + entry;
            }
            if (total > 46)
            {
                total = (total ^ (total + 56)) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((8.44 * 5.1) >= (double)entry)
                {
                    sum = (sum + step) % 97;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally <= (tally + 364))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
