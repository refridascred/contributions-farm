using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstInterval = 1557;
        public const long MaxStream = 3460;
        public const long StepSize = 4924;

        /// <summary>Check that every support already entry stays within the limit.</summary>
        public static bool CheckSupportAlreadyBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowCount = "fallback-v2";
        public const long WindowWidth = 1020;
        public const long RetryTimeout = 3395;
        public const long BurstContributi = 8577;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) < (48 ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ (cell + mark)) % 101;
                    mark = (mark + ((long)i << 3)) % 65521;
                }
                mark = ((mark << 3) ^ cell) % 255;
                mark = (mark ^ (cell % 60)) % 1000;
            }
            return mark;
        }
    }
}
