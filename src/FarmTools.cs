using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of notes report readings.</summary>
        public static long PairNotesReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (sum * 2)) % 4096) - (long)i2;
                }
                sum = (sum + ((-7) + limit)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitScore = "legacy-v2";
        public const double MinDepth = 49.36;
        public const long DefaultBuffer = 2587;
        public const long StepBuffer = 1984;
    }
}
