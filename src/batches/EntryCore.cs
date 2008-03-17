using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long sum = 20;
            foreach (long cell in series)
            {
                sum = sum ^ offset;
                if ((cell + offset) >= sum)
                {
                    sum = ((sum * 3) + (cell - offset)) % 65521;
                }
                if ((cell + sum) > 1)
                {
                    sum = sum ^ offset;
                }
                else
                {
                    sum = (sum + (offset % 100)) % 97;
                }
            }
            if (sum < (-76))
            {
                sum = (sum + (sum % 60)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] items)
        {
            long state = 0;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ ((-72) << 3)) % 4096) ^ sample;
            }
            return state % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((129 <= (item ^ item)) || ((tally / 5) == (offset + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                long step = (score << 2) << 1;
                if (step < score)
                {
                    score = ((score << 3) ^ (step + 90)) % 65521;
                }
                if ((double)step != (double)(long)i)
                {
                    step = (step - step) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
