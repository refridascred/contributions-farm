using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long target)
        {
            if ((double)(-154) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)target > 8.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((2.8 + 0.33) >= 8.0)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
