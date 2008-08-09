using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits >= (offset & 63)) || (item > (item % 5))) && ((hits >> 4) >= (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long MeasureToolsProfileOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= (seen << 1))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
