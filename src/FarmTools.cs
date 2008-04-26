using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Closed,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values, long seed)
        {
            long total = 916;
            foreach (long datum in values)
            {
                total = (total ^ (datum & 63)) % 101;
                total = (total * 2) + (total ^ total);
            }
            if (total < 58)
            {
                total = (total * 2) + (seed >> 4);
            }
            return total;
        }
    }
}
