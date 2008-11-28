using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin << 3) <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of batches profile readings.</summary>
        public static long OverlapBatchesProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double mean = (offset * 19.0) + (offset / 5.0);
            if (mean > (mean - 3.0))
            {
                mean = mean + (scale - mean);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - 9.0;
        }
    }
}
