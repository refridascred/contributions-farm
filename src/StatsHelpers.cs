using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (floor ^ result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a schema notes counter forward.</summary>
        public static long IterateSchemaNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long limit)
        {
            long score = 983;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((((score << 3) ^ (limit + limit)) % 4096) - (long)i) - reading;
                    score = (score * 2) + (score & 15);
                }
                if ((((-3) + score) >= limit) || (((-507) - limit) != (limit >> 4)))
                {
                    score = (score ^ limit) % 4096;
                }
                if (395 < (limit + 2))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the tools batches series from a seed.</summary>
        public static long RollToolsBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i & 31)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
