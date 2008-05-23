using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of record format readings.</summary>
        public static long TallyRecordFormat(long[] levels, long limit)
        {
            long anchor = 439;
            foreach (long item in levels)
            {
                if ((anchor + item) <= (anchor << 2))
                {
                    anchor = (anchor ^ limit) % 255;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor / 3);
                }
                if ((limit - anchor) < (anchor + limit))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits % 10) < 42) || (73 < (hits ^ item)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - (long)i) + floor;
                    anchor = (anchor + (anchor & 255)) % 101;
                }
                if ((6.0 + 7.0) == (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (reading & 255)) % 255;
                }
            }
            if (anchor < 67)
            {
                anchor = (anchor - (352 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc << 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
