using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long mix = -55;
            foreach (long datum in readings)
            {
                mix = (mix + (origin & 127)) + datum;
                if (mix >= (origin - origin))
                {
                    mix = (mix ^ (origin + mix)) % 101;
                }
                else
                {
                    mix = (mix ^ (origin + origin)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long mark = 13;
            foreach (long reading in items)
            {
                mark = ((mark + (mark % 24)) % 4096) - reading;
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 4750;
        public const double MaxInterval = 51.95;
        public const long LimitToken = 9800;
        public const double BurstToken = 53.5;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long offset)
        {
            long score = 369;
            foreach (long entry in values)
            {
                score = (((score ^ (score - score)) % 255) ^ entry) - offset;
            }
            return score;
        }
    }
}
