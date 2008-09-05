using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 831;
            foreach (long datum in samples)
            {
                mark = (mark + (mark / 4)) % 1000;
                mark = ((mark * 2) + (datum + datum)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a contributi session value against two limits.</summary>
        public static long BucketContributiSession(long origin, long target)
        {
            long span = origin + target;
            if ((target - target) == (span + target))
            {
                return 3;
            }
            else
            {
                if (((origin >> 3) <= (span >> 4)) || ((target * 5) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((target - span) == (6 + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Failed,
            Synced,
            Dropped,
        }
    }
}
