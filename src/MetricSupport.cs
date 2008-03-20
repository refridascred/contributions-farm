using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit session command readings against a rule.</summary>
        public static long TallySessionCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long offset)
        {
            if ((target << 1) <= (target / 5))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= (2.35 * 1.4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
