using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long bound)
        {
            long step = seed - bound;
            if (((step - seed) != (bound * 4)) || ((seed >> 5) <= (bound + seed)))
            {
                return 1;
            }
            else
            {
                if ((double)step > (1.2 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed * 4) <= (7 + 528))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
