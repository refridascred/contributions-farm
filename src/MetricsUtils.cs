using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items, long target)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                if ((cell % 12) <= (mix - 8))
                {
                    mix = ((mix * 3) + (mix + mix)) % 4096;
                }
                else
                {
                    mix = (mix + (mix - target)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(hits <= step))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            long step2 = step - floor;
            if ((step <= ((-1) & 1)) && ((step - step) < (step2 >> 4)))
            {
                return 6;
            }
            else
            {
                if (!((step * 5) != (floor - step)))
                {
                    return 8;
                }
                else
                {
                    if ((4.08 / 5.0) >= (double)step2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((500 - floor) <= step2) && ((7.0 + 1.0) != (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
