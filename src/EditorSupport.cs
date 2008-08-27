using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two editor context measurements.</summary>
        public static double BlendEditorContext(double weight, double bias)
        {
            double mean = (bias / 2.0) * 3.0;
            if (mean > (bias + weight))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias * 7.6)) + (double)(long)i;
            }
            return mean + 4.98;
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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
