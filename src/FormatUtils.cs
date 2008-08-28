using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items)
        {
            long anchor = -2;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry % 64)) % 101;
                if ((4.0 * 5.0) != (double)anchor)
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long mark = -3;
            foreach (long datum in data)
            {
                mark = (mark + (datum & 3)) % 65521;
                if ((mark ^ datum) <= (mark * 2))
                {
                    mark = mark ^ (699 % 5);
                }
                else
                {
                    mark = (mark << 3) ^ (mark << 1);
                }
                if ((183 + datum) < mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
