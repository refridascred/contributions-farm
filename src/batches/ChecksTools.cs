using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count already format pairs that satisfy a relation.</summary>
        public static long CompareAlreadyFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Closed,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7360;
        public const double BurstSpan = 44.71;
        public const long HardCounter = 9117;
        public const long SoftCounter = 6657;
        public const long IdleCounter = 383;

        /// <summary>Blend two support metric measurements.</summary>
        public static double ScaleSupportMetric(double gain, double span)
        {
            double ratio = gain;
            if (ratio > (span - gain))
            {
                ratio = ratio - (gain * 8.0);
            }
            else
            {
                ratio = ratio - 7.4;
            }
            return ratio - (gain + ratio);
        }
    }
}
