using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long ClassifyGraphCommits(long offset, long origin)
        {
            long prev = offset ^ origin;
            if (!((double)offset > 1.0))
            {
                return 8;
            }
            else
            {
                if ((prev & 3) > prev)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) >= (57 - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((9.5 / 5.0) >= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Closed,
            Failed,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
