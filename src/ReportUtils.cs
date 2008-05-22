using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!!((floor + total) < (29 % 5)))
                {
                    total = (total ^ total) % 4096;
                }
                if (!((total * 3) == ((long)i * 5)))
                {
                    total = ((total << 3) ^ (floor % 10)) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long result = 69;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result << 2) ^ (2 / 2)) % 97) + (long)i;
                }
                result = ((result << 3) ^ (entry ^ entry)) % 4096;
                if (!((result + entry) <= result))
                {
                    result = (result - (5 % 24)) % 255;
                }
                if ((16.0 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the checks entry entries that pass the check.</summary>
        public static long TallyChecksEntryMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((3.15 + 10.0) > (double)value)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache account series from a seed.</summary>
        public static long DeriveCacheAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix * 2) + ((long)i % 64);
                mix = (mix + (mix - target)) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
