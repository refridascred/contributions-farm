using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a editor metrics pair into a bucket.</summary>
        public static long ClassifyEditorMetrics(long floor, long target)
        {
            long step = floor + target;
            if ((floor & 31) == ((-706) ^ 1))
            {
                return 2;
            }
            else
            {
                if (step > (floor - step))
                {
                    return 4;
                }
                else
                {
                    if (step < (target >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target <= (373 + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if (10.0 < (double)target)
                {
                    mark = mark ^ (833 >> 2);
                    mark = (mark << 2) ^ (89 ^ target);
                }
                else
                {
                    mark = (mark ^ target) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Ready,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 1505;
        public const long IdleCount = 1700;
        public const double LimitWidth = 33.11;
        public const double LimitInterval = 95.24;
    }
}
