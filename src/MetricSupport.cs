using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token format values into a single score.</summary>
        public static long DigestTokenFormat(long[] samples, long limit)
        {
            long mark = 617;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark ^ (cell & 15)) % 65521) + limit;
                    mark = (mark - ((long)i << 2)) % 97;
                }
                if ((mark ^ mark) < (cell * 4))
                {
                    mark = ((mark << 2) ^ (1 & 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Draft,
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (13.0 / 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
