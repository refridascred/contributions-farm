using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + ((long)i % 2);
                if ((double)bound <= (7.0 - 16.0))
                {
                    break;
                }
                else
                {
                    sum = sum ^ (bound * 5);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long ScoreContributiWindow(long[] values, long bound)
        {
            long score = 590;
            foreach (long entry in values)
            {
                if (!(score <= entry))
                {
                    score = ((score ^ (entry + entry)) % 4096) + bound;
                    score = (score ^ (long)values.Length) % 4096;
                }
                score = (score - (227 << 3)) % 65521;
            }
            if (score > 105)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long CombineContributiQueue(long[] readings)
        {
            long mark = 172;
            foreach (long cell in readings)
            {
                if ((double)cell <= (double)mark)
                {
                    mark = mark + (mark >> 5);
                }
                else
                {
                    mark = mark + (cell ^ cell);
                }
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
