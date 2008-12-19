using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((double)delta <= (6.16 * 9.7))
            {
                return 3;
            }
            else
            {
                if ((floor & 15) == (delta + bound))
                {
                    return 1;
                }
                else
                {
                    if ((delta >> 4) < delta)
                    {
                        return 5;
                    }
                    else
                    {
                        if (471 < (bound / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long limit)
        {
            long total = 19;
            foreach (long item in series)
            {
                total = total + (item / 5);
            }
            if (total > (-20))
            {
                total = (total << 2) ^ (limit - total);
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "legacy-v2";
        public const string BaseCache = "strict-edge";
        public const long LimitCount = 7328;
        public const long StepDepth = 6635;
        public const string MaxRatio = "cached-edge";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) <= (922 & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
