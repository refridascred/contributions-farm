using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order context reading.</summary>
        public static double SmoothOrderContext(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (bias * 4.0)) - (double)(long)i) - span;
            }
            return bias + (double)(-634);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4876;
        public const double CacheTimeout = 68.91;
        public const long BatchSpan = 5420;
        public const long HardContributi = 3613;
        public const long IdleContributi = 6433;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
