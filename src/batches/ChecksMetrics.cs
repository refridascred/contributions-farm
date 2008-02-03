using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long limit)
        {
            long diff = step - limit;
            if ((double)diff != (13.0 + 7.34))
            {
                return 8;
            }
            else
            {
                if ((limit + step) >= (step - limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit > (limit ^ step)) || ((limit ^ limit) < limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 7.22;
        public const long BatchSession = 2150;
        public const long IdleSession = 4575;
        public const long BurstSession = 5904;
        public const double HardSession = 90.82;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long total = 75;
            foreach (long cell in levels)
            {
                total = (total - (cell & 7)) % 101;
                total = ((total * 2) + (cell - cell)) % 97;
                total = (total * 5) + 982;
            }
            if (total > 5)
            {
                total = total ^ (total % 24);
            }
            return total;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Audit token channel readings against a rule.</summary>
        public static long MeasureTokenChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((7.91 + 0.7) < (double)cell) && (hits >= (cell & 255)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
