using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((351 & 1) >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (origin <= (origin * 5))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Validate farm stream readings against a bound.</summary>
        public static bool CheckFarmStreamRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double offset)
        {
            double ratio = (double)(5 << 2);
            if (ratio <= 5.89)
            {
                ratio = (ratio + offset) + weight;
            }
            return ratio + offset;
        }
    }
}
