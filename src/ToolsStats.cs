using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long DeriveRecordContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series, long floor)
        {
            long acc = 11;
            foreach (long reading in series)
            {
                if (!((acc + reading) > (reading - floor)))
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long target)
        {
            long offset = limit - target;
            if ((limit + offset) > target)
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)6)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings, long origin)
        {
            long total = 82;
            foreach (long cell in readings)
            {
                if (origin <= (3 << 3))
                {
                    total = total - (cell / 9);
                }
            }
            return total % 97;
        }
    }
}
