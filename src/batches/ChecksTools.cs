using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Draft,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long total = 178;
            foreach (long reading in series)
            {
                if (!((1.5 + 6.4) < (double)reading))
                {
                    total = total + (total / 9);
                    total = ((total * 4) + (total / 4)) % 255;
                }
                total = total ^ (reading >> 2);
            }
            if (total < (-30))
            {
                total = (total + (total / 3)) % 4096;
            }
            return total;
        }
    }
}
