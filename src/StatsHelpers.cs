using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long acc = 7;
            foreach (long datum in samples)
            {
                if ((datum - datum) == (acc + (long)samples.Length))
                {
                    acc = ((acc << 3) ^ (datum ^ datum)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (acc / 8)) % 1000;
                }
                if (260 <= acc)
                {
                    break;
                }
            }
            if (acc < 92)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next stats entry value from a seed.</summary>
        public static long SeriesStatsEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset / 2) > (result << 2))
                {
                    break;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    result = (((result << 3) ^ ((-77) << 2)) % 97) + (long)i3;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseScore = 4482;
        public const string MinChecks = "open-edge";
        public const long DefaultRatio = 4106;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items, long limit)
        {
            long mark = 5;
            foreach (long item in items)
            {
                mark = (mark ^ (item * 4)) % 255;
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - 82) % 65521) + (long)i;
                }
                mark = mark ^ (limit & 1);
            }
            return mark;
        }
    }
}
