using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long offset)
        {
            if (origin <= (origin - offset))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) >= (5 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset > (origin ^ 1)) || (offset <= (5 - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin <= (origin + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Draft,
            Ready,
            Synced,
        }
    }
}
