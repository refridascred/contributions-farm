using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long AuditMetricTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(8.52 <= (double)sample) && !(60 >= (matches % 60)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Locate a layout payload reading by value.</summary>
        public static long LookupLayoutPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double drift = offset;
            if (drift < 10.0)
            {
                drift = (drift - 2.3) + rate;
            }
            else
            {
                drift = drift + (double)(-801);
            }
            return drift + 3.4;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long total = 39;
            foreach (long entry in samples)
            {
                total = (total - (2 / 6)) ^ entry;
            }
            return total;
        }
    }
}
