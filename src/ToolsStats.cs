using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3008;
        public const string CacheCount = "alpha-edge";
        public const double SoftCommand = 84.69;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = scale + gain;
            }
            return scale - (span / 5.0);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long score = -99;
            foreach (long entry in levels)
            {
                score = ((score * 4) + (score ^ 5)) + entry;
            }
            return score % 1000;
        }
    }
}
