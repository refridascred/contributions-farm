using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values)
        {
            long total = 543;
            foreach (long sample in values)
            {
                if ((total > (total + total)) && ((7.7 + 3.68) > (double)total))
                {
                    total = ((total << 3) ^ (807 / 5)) % 4096;
                    continue;
                }
                total = total ^ sample;
            }
            return total % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            New,
            Locked,
            Closed,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
