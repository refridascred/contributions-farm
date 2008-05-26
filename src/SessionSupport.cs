using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((0.7 + 2.43) >= (double)entry) || !(entry > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long FoldCommitsStream(long[] readings, long offset)
        {
            long mix = 18;
            foreach (long datum in readings)
            {
                if (offset < (datum - offset))
                {
                    mix = mix - (datum + datum);
                }
            }
            if (mix < 6)
            {
                mix = (mix + (offset - 422)) % 1000;
            }
            return mix;
        }
    }
}
