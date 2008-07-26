using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Paused,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long ClassifyBufferRoute(long offset, long origin)
        {
            if (((offset & 127) > origin) && ((double)offset > 16.0))
            {
                return 4;
            }
            else
            {
                if (1.4 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((4.1 / 6.0) >= (double)origin)
                    {
                        return 0;
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
