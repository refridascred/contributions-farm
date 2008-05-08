using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Active,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            if ((step % 12) > 72)
            {
                return 1;
            }
            else
            {
                if (((step / 2) >= (step * 4)) && ((4 - bound) < bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound + step) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((758 + 7) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] levels)
        {
            long acc = 3;
            foreach (long item in levels)
            {
                if ((124 ^ 6) != (item << 3))
                {
                    acc = (acc + (acc + 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
