using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 7.49;
        public const string IdleTimeout = "standard";
        public const long StepEditor = 5217;
        public const string MaxEditor = "staging";
        public const double LimitRatio = 92.67;

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long origin)
        {
            if ((double)origin == (18.0 * 1.39))
            {
                return 6;
            }
            else
            {
                if (seed > 977)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((mark - mark) < (mark >> 5))
                {
                    mark = (mark ^ offset) % 101;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long CountPayloadFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally + (long)data.Length) > (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
