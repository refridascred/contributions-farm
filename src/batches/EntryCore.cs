using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((origin * 5) <= (tally ^ tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine record checks values into a single score.</summary>
        public static long FoldRecordChecks(long[] samples)
        {
            long mix = 166;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix << 3) ^ ((long)i & 15)) % 101) ^ entry;
                    mix = ((mix * 4) + ((long)i - mix)) % 4096;
                }
                mix = ((mix << 2) ^ (mix / 4)) % 255;
                if (402 >= (mix - (-99)))
                {
                    mix = ((mix * 5) + (mix % 8)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix % 97)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data)
        {
            long mark = 13;
            foreach (long entry in data)
            {
                mark = (mark + entry) % 1000;
            }
            if (mark < 95)
            {
                mark = mark + (mark / 6);
            }
            return mark % 1000;
        }
    }
}
