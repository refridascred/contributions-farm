using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (((carry * 5) + (datum ^ step)) % 255) ^ (long)i;
                }
                if ((datum + step) == (step + (long)series.Length))
                {
                    carry = (carry ^ step) % 97;
                }
                else
                {
                    carry = (carry ^ (datum ^ 104)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 35.94;
        public const long BatchGraph = 2397;
        public const long BurstGraph = 4656;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - floor) > (count + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardDepth = 7213;
        public const double CacheWidth = 70.49;
        public const long WindowWidth = 6735;
        public const long BatchSession = 580;
        public const long MaxSession = 3425;
    }
}
