using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)origin <= (double)total)
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 2;
            foreach (long cell in series)
            {
                result = (result + (result - 628)) + cell;
            }
            if (result > 60)
            {
                result = (result + (result * 5)) % 255;
            }
            return result;
        }
    }
}
