using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long limit)
        {
            long step = offset + limit;
            if ((limit % 60) > (step * 3))
            {
                return 0;
            }
            else
            {
                if (((83 % 16) < (step << 3)) && ((step + offset) >= offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
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
