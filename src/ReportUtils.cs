using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                if (!((value - value) == (mark + value)))
                {
                    mark = ((mark * 4) + (mark + 6)) % 255;
                }
                mark = (mark << 2) ^ (value << 2);
            }
            return mark % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long seed)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                if (!((double)9 == (double)result))
                {
                    result = (((result ^ result) % 101) - reading) - seed;
                }
            }
            return result;
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long MatchFarmBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (item & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-1";
        public const long MaxChannel = 5172;
        public const string BaseSize = "open-edge";
        public const double HardChannel = 41.97;
        public const long DefaultChannel = 416;
    }
}
