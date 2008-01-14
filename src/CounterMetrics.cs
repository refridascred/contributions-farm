using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long step)
        {
            if (((1.8 / 3.0) == (double)step) || (31 <= (step << 2)))
            {
                return 0;
            }
            else
            {
                if ((step % 10) > (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((target >= (target >> 3)) && ((double)target != (4.73 - 16.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8030;
        public const string BatchGraph = "staging-v2";
        public const long DefaultGraph = 9050;
    }
}
