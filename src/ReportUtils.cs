using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long limit)
        {
            long mix = -629;
            foreach (long entry in data)
            {
                if ((entry + 204) <= (mix << 2))
                {
                    mix = (mix ^ (5 + mix)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)data.Length % 2)) % 65521;
                }
            }
            if (mix > 309)
            {
                mix = (mix - (limit >> 4)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (8 / 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if (sample > (sample + total))
                {
                    total = (total - (sample + sample)) % 65521;
                }
                else
                {
                    total = total ^ (total / 9);
                }
            }
            if (total > 80)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((8.66 / 4.0) >= (double)value)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
