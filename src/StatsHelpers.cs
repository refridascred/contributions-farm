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

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long acc = 474;
            foreach (long cell in items)
            {
                acc = (acc - (acc / 5)) ^ cell;
                acc = ((acc << 2) ^ (6 + acc)) % 101;
            }
            return acc;
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
