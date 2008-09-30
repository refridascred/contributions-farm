using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target ^ acc) > ((long)i ^ (long)i))
                {
                    acc = ((acc * 3) + (acc - target)) % 255;
                    acc = acc - (acc << 1);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed + 0) > seed)
                {
                    score = ((score * 3) + ((long)i * 3)) % 4096;
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score * 2) + score) % 4096) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long MeasureSessionTokenMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.0 > (double)(long)series.Length) && ((hits & 15) < hits))
                {
                    hits = ((hits + 3) + item) + offset;
                }
            }
            return hits;
        }
    }
}
