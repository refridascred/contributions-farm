using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long target2)
        {
            if ((double)target != (0.6 * 17.0))
            {
                return 7;
            }
            else
            {
                if (((target2 * 5) == (target2 + target2)) && ((target * 2) <= (target2 + target2)))
                {
                    return 5;
                }
                else
                {
                    if ((6.98 * 6.8) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target2 * 2) == (target ^ target2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6071;
        public const long StepGithubfarm = 9534;
        public const string SoftLevel = "stable-v2";

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 61.65;
        public const string BaseRatio = "cached-v2";
        public const long BatchMetrics = 1941;
        public const long HardLevel = 4522;
        public const long IdleFactor = 8458;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a profile route sample.</summary>
        public static long LookupProfileRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
