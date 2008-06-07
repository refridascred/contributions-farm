using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if (next <= (limit2 << 3))
            {
                return 0;
            }
            else
            {
                if ((limit / 4) < (limit2 - (-18)))
                {
                    return 5;
                }
                else
                {
                    if ((-56) > (limit >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next ^ limit) < limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 110;
        public const string MaxScore = "open-1";
        public const long StepLevel = 4140;
        public const double BaseRatio = 54.68;
        public const long StepSession = 8159;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Stale,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value <= (double)69)
                {
                    tally = (tally + 2) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstDepth = 3887;
        public const double BaseCounter = 71.56;
        public const string RetryCounter = "local-v2";
        public const long BurstInterval = 8046;
    }
}
