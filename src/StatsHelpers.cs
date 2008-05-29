using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of stream notes entries.</summary>
        public static long FoldStreamNotes(long[] series)
        {
            long acc = 1;
            foreach (long value in series)
            {
                acc = (acc + value) % 97;
                if ((double)acc > (9.38 / 8.0))
                {
                    acc = acc ^ 50;
                }
            }
            if (acc > 944)
            {
                acc = (acc << 2) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Measure how many session stats samples are out of range.</summary>
        public static long CountSessionStatsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + step) < value) && (step < (tally - step)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long score = 125;
            foreach (long cell in readings)
            {
                if (!(score > (cell << 1)))
                {
                    score = (score ^ (score * 2)) % 101;
                }
                if (score >= (cell - cell))
                {
                    score = (score + (-22)) % 4096;
                    score = score + (score * 2);
                }
                score = (score * 3) + cell;
            }
            return score;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 92.44;
        public const double BatchNotes = 23.3;
        public const long MaxRatio = 5743;
        public const long CacheDepth = 5065;
    }
}
