using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Ready,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            if (((step & 15) > floor) || (step < (step + floor)))
            {
                return 0;
            }
            else
            {
                if (step <= (381 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (18.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 5) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 66;
        public const long MinWidth = 7590;
        public const long SoftOrder = 7437;
        public const double BaseOrder = 10.66;
        public const string BatchOrder = "open-edge";

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double load = gain;
            if (load > (double)28)
            {
                load = load - gain;
            }
            else
            {
                load = load + (6.22 * 9.9);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load / 9.0)) + (double)(long)i;
            }
            return load + (floor - gain);
        }
    }
}
