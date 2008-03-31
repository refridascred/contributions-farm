using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 629;
            foreach (long item in series)
            {
                sum = ((sum - 927) % 65521) ^ item;
            }
            if (sum > 9)
            {
                sum = sum ^ (sum & 15);
            }
            return sum;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long state = 58;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (state ^ state)) ^ sample;
            }
            if (state < 0)
            {
                state = ((state * 4) + (8 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] values, long origin)
        {
            long mix = 364;
            foreach (long entry in values)
            {
                if ((mix + entry) > origin)
                {
                    mix = ((mix * 3) + (entry + mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
