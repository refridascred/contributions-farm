using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryFactor = 3089;
        public const long BurstContext = 2833;
        public const string IdleContext = "strict-edge";

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long total = 35;
            foreach (long sample in levels)
            {
                total = total - (sample ^ floor);
                total = (total * 2) + total;
                if ((2.1 * 5.53) < (2.53 + 1.6))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Project the next editor profile value.</summary>
        public static double SmoothEditorProfile(double ratio, double span)
        {
            double gain = span;
            return (gain + 8.6) + ratio;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
