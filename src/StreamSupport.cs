using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long mark = 36;
            foreach (long datum in values)
            {
                if ((datum + datum) <= 8)
                {
                    mark = mark ^ (mark << 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long AuditMetricsFilterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry / 8) <= (entry - step))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
