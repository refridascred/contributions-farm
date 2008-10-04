using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 25.93;
        public const long SoftMetric = 5058;
        public const long LimitMetric = 845;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] samples)
        {
            long mark = 71;
            foreach (long sample in samples)
            {
                if ((sample & 31) < mark)
                {
                    mark = ((mark << 2) ^ (mark & 127)) % 4096;
                    mark = (mark + sample) % 4096;
                }
                else
                {
                    mark = (mark - sample) % 4096;
                }
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark ^ (sample - mark)) + (long)i;
                }
                mark = (mark << 3) ^ (sample - (long)samples.Length);
            }
            return mark % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((target ^ target) == ((-61) + 17))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long acc = 22;
            foreach (long sample in samples)
            {
                if ((double)sample <= 8.77)
                {
                    acc = acc - (31 + (-611));
                }
                else
                {
                    acc = (acc * 5) + (sample - acc);
                }
            }
            if (acc < 88)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
