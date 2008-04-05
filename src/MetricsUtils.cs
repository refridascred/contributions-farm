using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (result >> 5)) % 65521;
                result = result ^ (datum - 885);
                result = result ^ (datum << 2);
            }
            if (result < 7)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step <= (step >> 4)) || (((long)i / 4) >= (step * 4)))
                {
                    score = ((score * 3) + 8) % 101;
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long bound)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if ((8.43 - 9.2) >= (double)sample)
                {
                    mark = (mark << 3) ^ (long)values.Length;
                }
            }
            if (mark < 511)
            {
                mark = mark - (bound - mark);
            }
            return mark;
        }
    }
}
