using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxTimeout = "fallback-v2";
        public const string StepReport = "standard-edge";
        public const long IdleReport = 2174;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cache order samples.</summary>
        public static long WeighCacheOrder(long[] series, long bound)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = ((((score * 2) + score) % 255) - value) - bound;
            }
            return score;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                if ((51 - result) == (sample + sample))
                {
                    result = (result + (long)readings.Length) % 101;
                    break;
                }
                if (!((73 ^ sample) >= (sample / 2)))
                {
                    result = (result ^ (sample - result)) % 1000;
                }
                if ((result >> 5) >= (742 * 5))
                {
                    result = result ^ (result - 5);
                }
            }
            if (result < 367)
            {
                result = (result + ((-4) / 3)) % 65521;
            }
            return result;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= (double)21)
            {
                gain = (gain + 2.46) - offset;
            }
            return gain - ratio;
        }
    }
}
