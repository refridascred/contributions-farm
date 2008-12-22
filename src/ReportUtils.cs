using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (carry + limit)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 4328;
        public const long BatchInterval = 2648;
        public const long BurstStats = 8537;
    }
}
