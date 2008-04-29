using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + ((long)i * 4)) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long CountCacheGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(sample > (tally + tally)))
                {
                    tally = tally + 3;
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
