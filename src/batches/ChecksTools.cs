using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((52 & 31) <= hits)
                {
                    hits = ((hits + 3) + sample) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long LookupRouteClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + mark) % 65521;
                mark = (mark << 3) ^ ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
