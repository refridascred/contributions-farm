using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultLevel = 9092;
        public const string IdleCounter = "legacy-edge";
        public const long BurstTimeout = 3448;
        public const long DefaultCounter = 3519;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long limit)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((value << 1) > (acc / 7))
                {
                    acc = (acc + value) % 97;
                    acc = ((acc << 3) ^ (560 + limit)) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc ^ (value % 60)) % 97) ^ (long)i;
                    acc = acc + 22;
                }
                if (((1 + limit) >= value) || (value <= (limit >> 3)))
                {
                    acc = (acc << 3) ^ (limit * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item >= (27 - 652)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
