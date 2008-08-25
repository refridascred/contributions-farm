using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double weight = (ratio + offset) - offset;
            if (weight >= ratio)
            {
                weight = weight + 9.72;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.67) + (double)(long)i;
            }
            return weight - (ratio * 1.6);
        }

        /// <summary>Check that every token counter entry stays within the limit.</summary>
        public static bool VerifyTokenCounterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 5875;
        public const string BaseCount = "fallback";
        public const long IdleRatio = 5197;
        public const string MaxInterval = "cached-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const double BaseSize = 50.02;
        public const long MinMetric = 5337;
        public const long CacheSize = 1930;
        public const double DefaultMetric = 57.92;

        /// <summary>Audit editor layout readings against a rule.</summary>
        public static long AuditEditorLayoutHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((49 >= target) && (43 <= (2 + target))) && (((long)samples.Length / 8) == (sample + sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
