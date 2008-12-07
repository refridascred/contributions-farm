using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of entry support entries.</summary>
        public static long CombineEntrySupport(long[] series, long origin)
        {
            long total = 359;
            foreach (long sample in series)
            {
                if ((11 * 3) < (total ^ origin))
                {
                    total = ((total << 3) ^ total) % 97;
                }
                else
                {
                    total = total ^ (sample >> 3);
                    total = (total - (334 % 100)) % 4096;
                }
                if (origin < (sample - origin))
                {
                    total = total ^ sample;
                }
                total = ((total * 5) + (total % 5)) % 255;
            }
            if (total < 20)
            {
                total = (total - (862 - origin)) % 255;
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(((floor + 479) <= (mix & 255)) && ((0 + (long)i) >= (long)i)))
                {
                    mix = mix - (mix - 8);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long result = 561;
            foreach (long value in series)
            {
                result = (((result << 2) ^ (1 ^ floor)) % 1000) ^ value;
            }
            return result;
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
