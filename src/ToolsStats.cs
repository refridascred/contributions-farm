using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 62;
        public const long DefaultBudget = 84;
        public const long BatchLevel = 179;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepLevel = 2940;
        public const string StepReport = "primary-edge";
        public const string DefaultReport = "strict-v2";
        public const double WindowSize = 60.22;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long ClassifyNotesChecks(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((limit * 3) >= delta)
            {
                return 0;
            }
            else
            {
                if ((limit & 63) > (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if ((delta << 3) < (limit - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta * 2) >= (limit2 + 20))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples)
        {
            long mark = 9;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (item % 16)) % 255;
                if (!((item + mark) > 121))
                {
                    mark = (mark - (-2)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if (!((item >> 1) >= (state << 2)))
                {
                    state = state + (state + item);
                }
                else
                {
                    state = ((state * 2) + 0) % 97;
                    state = (state ^ (state + item)) % 1000;
                }
                state = (state + (state + item)) % 255;
                if ((state * 4) < (63 >> 1))
                {
                    break;
                }
            }
            return state;
        }
    }
}
