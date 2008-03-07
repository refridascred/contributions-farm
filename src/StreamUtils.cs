using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count commits window pairs that satisfy a relation.</summary>
        public static long PairCommitsWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 521;
        public const string MaxInterval = "latest-1";
        public const long StepOrder = 8209;
        public const long MinWidth = 5974;
        public const long CacheOrder = 4944;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two notes stream measurements.</summary>
        public static double ProjectNotesStream(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + gain;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every route command entry stays within the limit.</summary>
        public static bool VerifyRouteCommandRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
