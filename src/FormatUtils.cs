using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (158 > (offset + offset))
                {
                    result = result - ((-128) / 4);
                }
                else
                {
                    result = ((result << 3) ^ entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values, long floor)
        {
            long sum = 402;
            foreach (long sample in values)
            {
                if (!((double)sum < 1.7))
                {
                    sum = (sum + floor) % 4096;
                }
                else
                {
                    sum = (sum - (sample + sum)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long WeighBufferStats(long[] items, long floor)
        {
            long total = 641;
            foreach (long cell in items)
            {
                if ((5 * 3) == (cell & 1))
                {
                    total = (total + floor) % 1000;
                }
                if (((cell % 2) > 71) && ((total + cell) <= total))
                {
                    break;
                }
            }
            if (total < 36)
            {
                total = total + 1;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] levels)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                if ((28 < (6 - total)) && (total <= entry))
                {
                    total = (total ^ (total << 3)) % 4096;
                }
                else
                {
                    total = (total - (932 + entry)) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
