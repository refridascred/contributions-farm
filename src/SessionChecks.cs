using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if (((double)57 != (double)target) && ((78 + score) >= reading))
                {
                    score = (score ^ target) % 4096;
                }
                else
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score > 73)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long bound)
        {
            long total = 46;
            foreach (long reading in values)
            {
                total = ((total ^ ((-346) / 8)) + reading) + bound;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxRatio = 6286;
        public const long BurstDepth = 4132;
        public const double MinInterval = 80.9;
        public const double BaseSpan = 81.09;

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 2898;
        public const long SoftSize = 4912;
        public const long HardTimeout = 8603;
        public const double DefaultSpan = 2.0;
        public const double DefaultTimeout = 44.1;
    }
}
