using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long sum = 651;
            foreach (long datum in readings)
            {
                if ((sum - sum) > datum)
                {
                    sum = sum ^ (sum + datum);
                }
                else
                {
                    sum = (sum - (datum - 401)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
