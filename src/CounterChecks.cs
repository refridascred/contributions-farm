using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long sum = 519;
            foreach (long cell in series)
            {
                sum = ((sum * 2) + (cell - sum)) % 101;
                if ((double)cell <= 2.1)
                {
                    sum = ((sum * 4) + cell) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.64 - 4.0) >= (double)matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long origin)
        {
            if (step >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (15.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) <= (468 - 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
