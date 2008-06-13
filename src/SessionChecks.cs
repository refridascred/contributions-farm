using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit already filter readings against a rule.</summary>
        public static long MeasureAlreadyFilterOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen % 64) < (seen ^ sample))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Match up notes schema samples.</summary>
        public static long PairNotesSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items, long bound)
        {
            long total = 971;
            foreach (long datum in items)
            {
                if ((total + datum) != (bound >> 3))
                {
                    total = (total + bound) % 4096;
                }
            }
            if (total < 743)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }
    }
}
