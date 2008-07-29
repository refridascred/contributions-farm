using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseLevel = 21.5;
        public const long RetryGithubfarm = 2406;
        public const string CacheDepth = "primary-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= (scale / 9.0))
            {
                scale = (scale - scale) + ratio;
            }
            return scale + (double)62;
        }
    }
}
