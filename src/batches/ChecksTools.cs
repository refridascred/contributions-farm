using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit payload report readings against a rule.</summary>
        public static long TallyPayloadReportGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((step * 2) >= 66))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 8332;
        public const long MinFilter = 2885;
        public const long MinRatio = 4934;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9322;
        public const long MaxStream = 6798;
        public const long DefaultStream = 6916;
        public const long MaxDepth = 8803;
        public const long CacheStream = 5192;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long offset)
        {
            if (((double)floor != (3.5 - 0.55)) && ((offset + offset) < (offset * 5)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) > (floor << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
