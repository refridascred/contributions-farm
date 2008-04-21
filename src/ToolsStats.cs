using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 2661;
        public const long BurstProfile = 5667;
        public const long MaxCount = 2443;
        public const long BatchFactor = 8929;
        public const long CacheCount = 8179;

        /// <summary>Digest a series of profile format entries.</summary>
        public static long FoldProfileFormat(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (bound < (bound & 7))
                {
                    mix = (mix - bound) + item;
                }
            }
            return mix;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values)
        {
            long score = 7;
            foreach (long sample in values)
            {
                score = (score - (sample & 15)) % 1000;
                if (((861 - 22) != (score - 947)) || ((double)sample == (4.58 - 15.0)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long MeasureToolsFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
