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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double weight = (floor / 8.0) * 6.33;
            if (weight >= (floor / 7.0))
            {
                weight = (weight + floor) + bias;
            }
            else
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 8.0)) + (double)(long)i;
            }
            return weight - weight;
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
