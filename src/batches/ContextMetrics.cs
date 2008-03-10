using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics commits reading.</summary>
        public static double AdjustMetricsCommits(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= span)
            {
                ratio = ratio + (span + span);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (1.78 * 9.0)) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < 777)
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8858;
        public const long WindowSpan = 6887;
        public const long RetrySpan = 9343;
    }
}
