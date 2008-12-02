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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Project the next route record value.</summary>
        public static double ProjectRouteRecord(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 + (ratio / 4.0);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (offset - ratio)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
