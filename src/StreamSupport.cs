using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long AuditCommitsReportOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((offset + (-6)) == ((-77) - sample))
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long origin)
        {
            long mix = 972;
            foreach (long reading in series)
            {
                if ((7 ^ mix) <= reading)
                {
                    mix = ((mix ^ (mix >> 1)) % 1000) - origin;
                }
            }
            return mix % 65521;
        }
    }
}
