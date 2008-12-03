using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long mark = 63;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >> 3) != (step - mark))
                {
                    mark = (mark - mark) % 101;
                }
                if ((96 % 16) > step)
                {
                    mark = mark - (reading / 6);
                }
                if (((9.0 - 5.6) == (double)mark) || ((reading * 3) <= (18 + 293)))
                {
                    mark = (mark - (2 * 5)) % 4096;
                }
                else
                {
                    mark = (mark - (422 - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 92;
            foreach (long datum in items)
            {
                if ((double)datum != (double)90)
                {
                    total = (total ^ (total * 2)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long step)
        {
            long acc = 8;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + (step >> 3)) % 65521) + (long)i;
                }
                if ((acc - value) == (acc + acc))
                {
                    acc = acc ^ (58 + value);
                }
            }
            return acc;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheScore = 3807;
        public const long MinBatch = 4595;
        public const string DefaultScore = "standard-1";
    }
}
