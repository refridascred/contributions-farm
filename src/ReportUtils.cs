using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double scale = gain - (gain - 5.0);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 2.4) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Find the first commits counter entry that matches the target.</summary>
        public static long FindCommitsCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long acc = 43;
            foreach (long cell in samples)
            {
                if (cell < (cell - cell))
                {
                    acc = ((acc * 2) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = acc + (acc ^ cell);
                }
            }
            if (acc < (-59))
            {
                acc = ((acc << 2) ^ 336) % 255;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= (1.5 + 8.0)) || ((tally + entry) <= 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Locked,
            Active,
            Retry,
        }
    }
}
