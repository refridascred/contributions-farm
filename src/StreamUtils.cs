using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally < (entry - entry))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (score & 7)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long ScoreBufferChannel(long[] series)
        {
            long mark = -445;
            foreach (long value in series)
            {
                if (!((double)value != (4.6 + 9.0)))
                {
                    mark = (mark << 2) ^ (mark + value);
                }
                else
                {
                    mark = ((mark << 2) ^ 53) % 1000;
                }
                if (9.83 >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultSize = "primary-1";
        public const long IdleTimeout = 7626;
        public const long DefaultRecord = 2219;
        public const long BurstCount = 5071;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 95;
            foreach (long item in samples)
            {
                total = (total ^ (237 + item)) % 255;
            }
            return total;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Active,
            Stale,
            Paused,
        }
    }
}
