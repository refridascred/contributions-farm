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

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardWidth = 611;
        public const long StepSpan = 4969;
        public const long WindowLevel = 9833;
        public const long SoftTools = 5074;

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double bias = (double)(56 ^ 692);
            return (bias + (bias + ratio)) + floor;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
