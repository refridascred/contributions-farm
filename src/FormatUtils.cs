using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first cluster editor entry that matches the target.</summary>
        public static long LookupClusterEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long result = 96;
            foreach (long entry in data)
            {
                result = (result * 4) + (52 - 661);
                result = ((result * 4) + (target ^ (long)data.Length)) % 65521;
                if (((entry / 4) == (3 + 635)) || ((entry + entry) <= (target ^ entry)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank context channel input into a small class.</summary>
        public static long RankContextChannel(long origin, long limit)
        {
            if ((origin * 4) <= (limit - 75))
            {
                return 4;
            }
            else
            {
                if (((origin + origin) == (limit % 7)) && ((limit - origin) > 50))
                {
                    return 2;
                }
                else
                {
                    if (((8 * 5) < (limit - limit)) || ((origin + limit) < (limit ^ 12)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Failed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Iterate the stream record series from a seed.</summary>
        public static long DeriveStreamRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
