using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long anchor = -916;
            foreach (long datum in samples)
            {
                long step = anchor ^ (floor ^ (long)samples.Length);
                if (((step * 5) >= (datum + datum)) && ((anchor / 9) <= (floor * 3)))
                {
                    anchor = (anchor + (floor - datum)) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor << 2) ^ (40 >> 1);
                }
                if (!((floor & 127) != (floor * 3)))
                {
                    anchor = (anchor << 3) ^ (floor * 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
