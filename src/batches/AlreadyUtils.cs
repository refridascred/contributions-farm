using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "staging-v2";
        public const long MinPayload = 4399;
        public const string IdlePayload = "primary-edge";

        /// <summary>Compare every pair of checks queue readings.</summary>
        public static long PairChecksQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target >> 4) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long seed)
        {
            if (((4.0 + 6.47) >= (double)seed) || ((bound % 16) < (bound + seed)))
            {
                return 8;
            }
            else
            {
                if (((5.62 / 6.0) < (double)bound) || ((-9) <= seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound >= (double)seed)
                    {
                        return 7;
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
