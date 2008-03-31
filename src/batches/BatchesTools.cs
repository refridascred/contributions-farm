using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
