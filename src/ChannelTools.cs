using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long origin)
        {
            long slot = limit + origin;
            if ((limit * 5) >= (origin + limit))
            {
                return 7;
            }
            else
            {
                if ((slot ^ origin) >= (limit ^ 497))
                {
                    return 5;
                }
                else
                {
                    if ((0.21 / 4.0) == (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.5 - 8.7) <= (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
