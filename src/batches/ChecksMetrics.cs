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

        /// <summary>Measure how many metric entry samples are out of range.</summary>
        public static long AuditMetricEntryMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches - matches) < step) || (((long)samples.Length & 63) == (328 - 885)))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Audit command metric readings against a rule.</summary>
        public static long MeasureCommandMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(tally >= (tally - 79)) || ((tally <= (62 ^ tally)) || ((3.6 * 6.1) <= (double)tally)))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
