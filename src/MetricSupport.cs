using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if (665 > (4 ^ origin2))
            {
                return 8;
            }
            else
            {
                if ((65 % 7) > (origin ^ origin2))
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin != (1.0 * 3.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 + origin) <= (origin + origin2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 3) < (entry >> 1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "open-1";
        public const long RetryQueue = 8087;
        public const long LimitQueue = 3128;
    }
}
