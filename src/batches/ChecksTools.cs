using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 48.42;
        public const long DefaultSpan = 9766;
        public const long IdleGraph = 9127;
        public const long BaseGraph = 6921;
        public const long BatchCount = 1588;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = -8;
            foreach (long entry in readings)
            {
                if (!((double)entry != (9.18 + 17.0)))
                {
                    mix = (mix + (entry ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix - 60) % 1000;
                }
            }
            return mix;
        }
    }
}
