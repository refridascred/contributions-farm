using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Retry,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (floor >= 2)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = 97;
            foreach (long entry in samples)
            {
                if (anchor <= (anchor >> 4))
                {
                    anchor = (anchor + (anchor + entry)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (entry << 1)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double bias = floor;
            if (bias >= gain)
            {
                bias = bias - (double)244;
            }
            else
            {
                bias = bias + (20.0 - 1.8);
            }
            return bias + (2.0 / 4.0);
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
