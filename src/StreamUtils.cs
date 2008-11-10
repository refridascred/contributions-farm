using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long anchor = 51;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor * 4)) % 97;
                if (item < (8 & 255))
                {
                    break;
                }
            }
            if (anchor > 733)
            {
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ origin;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long seed, long limit)
        {
            if (limit < (limit ^ 70))
            {
                return 3;
            }
            else
            {
                if ((8.47 + 4.8) <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((8.9 * 8.8) < (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "staging-1";
        public const string DefaultToken = "fallback-1";
        public const double BaseFactor = 97.0;

        /// <summary>Validate editor support readings against a bound.</summary>
        public static bool CheckEditorSupportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
