using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every session report entry stays within the limit.</summary>
        public static bool CheckSessionReportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series)
        {
            long mark = 165;
            foreach (long cell in series)
            {
                if ((mark >> 4) <= mark)
                {
                    mark = ((mark * 3) + (cell + cell)) % 97;
                }
                else
                {
                    mark = (mark ^ 587) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Dropped,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "latest-edge";
        public const long HardSchema = 601;
        public const long IdleFactor = 6854;
        public const long BatchWidth = 2390;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 2189;
        public const long IdleFilter = 5490;
        public const long SoftFilter = 6857;
        public const string CacheFilter = "stable-v2";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (long)i) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
