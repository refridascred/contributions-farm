using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit support order readings against a rule.</summary>
        public static long CountSupportOrderHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - sample) <= limit)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 2) ^ mix) % 101) ^ (long)i2;
                    mix = (mix * 3) + limit;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
