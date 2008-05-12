using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long result = -13;
            foreach (long datum in items)
            {
                if (result >= (datum / 9))
                {
                    result = (result + (65 / 4)) % 101;
                }
                result = result + result;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long lane = seed + step;
            if ((lane / 3) <= (seed * 2))
            {
                return 5;
            }
            else
            {
                if (((58 - seed) >= ((-19) & 3)) || ((seed >> 1) > (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long origin)
        {
            long total = 304;
            foreach (long cell in readings)
            {
                if ((total / 3) <= (total ^ origin))
                {
                    total = ((total + (total / 6)) % 255) - cell;
                }
            }
            return total;
        }
    }
}
