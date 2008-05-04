using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "open";
        public const double RetryStream = 49.22;
        public const string LimitStream = "alpha";
        public const long StepStream = 3486;

        /// <summary>Look up the position of a already editor sample.</summary>
        public static long LocateAlreadyEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics checks entries.</summary>
        public static long ScoreMetricsChecks(long[] series)
        {
            long mark = 95;
            foreach (long entry in series)
            {
                if ((mark / 3) > (long)series.Length)
                {
                    mark = (mark << 3) ^ (mark + entry);
                }
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] data, long limit)
        {
            long result = -8;
            foreach (long cell in data)
            {
                result = ((result * 4) + limit) - cell;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result + (-27))) % 1000;
            }
            return result;
        }
    }
}
