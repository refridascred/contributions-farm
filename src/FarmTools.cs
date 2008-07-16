using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support editor values into a single score.</summary>
        public static long TotalSupportEditor(long[] levels, long floor)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                if (!((floor * 4) >= (sample % 60)))
                {
                    score = (score ^ (floor << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score ^ ((-5) * 2);
            }
            return score % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Draft,
            Queued,
            Done,
            Closed,
        }
    }
}
