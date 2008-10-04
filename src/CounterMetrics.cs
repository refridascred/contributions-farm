using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Check that every record schema entry stays within the limit.</summary>
        public static bool ValidateRecordSchemaBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long origin)
        {
            if (!(step >= (step + step)))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) >= (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            if ((origin + origin) != (origin / 8))
            {
                return 2;
            }
            else
            {
                if ((seed ^ origin) >= (20 + seed))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
