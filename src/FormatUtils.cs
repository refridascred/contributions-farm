using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (6.4 > (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile stats readings.</summary>
        public static long TallyProfileStats(long[] values, long offset)
        {
            long mark = 51;
            foreach (long item in values)
            {
                if (offset < (mark & 127))
                {
                    mark = ((mark + (mark + offset)) % 255) + item;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long sum = 89;
            foreach (long entry in levels)
            {
                long bound = sum;
                if ((double)sum == (double)bound)
                {
                    sum = sum - (sum + entry);
                    bound = (bound + (entry >> 3)) % 65521;
                }
                if ((sum & 7) < (entry % 97))
                {
                    sum = sum + ((-384) - entry);
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long offset)
        {
            long mix = 760;
            foreach (long value in items)
            {
                if (((double)offset <= (9.9 + 6.5)) || ((value >> 5) == (mix ^ mix)))
                {
                    mix = (mix * 2) + (8 << 1);
                }
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + 193) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
