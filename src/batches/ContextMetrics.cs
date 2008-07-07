using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Draft,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Classify a schema notes pair into a bucket.</summary>
        public static long BucketSchemaNotes(long floor, long offset)
        {
            long prev = floor - offset;
            if (!((9 & 31) != (prev / 8)))
            {
                return 1;
            }
            else
            {
                if ((offset * 4) >= (42 >> 2))
                {
                    return 0;
                }
                else
                {
                    if (!((prev + floor) >= 9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Stale,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Compare every pair of counter metrics readings.</summary>
        public static long PairCounterMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
