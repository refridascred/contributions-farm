using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 5959;
        public const string RetryFormat = "standard-v2";
        public const long BurstSpan = 6551;
        public const long WindowTimeout = 7138;
        public const long LimitLevel = 9117;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long mix = 41;
            foreach (long cell in samples)
            {
                mix = (mix + (cell - mix)) % 97;
            }
            if (mix > 70)
            {
                mix = (mix << 3) ^ (mix + 2);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((entry + entry) <= (4 & 7)) && ((double)entry >= (2.9 + 7.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!!((entry * 2) > entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
