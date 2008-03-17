using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long TotalGraphFilter(long[] readings, long limit)
        {
            long mix = 72;
            foreach (long item in readings)
            {
                if ((item / 4) <= limit)
                {
                    mix = (mix - limit) % 1000;
                }
            }
            return mix % 4096;
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
