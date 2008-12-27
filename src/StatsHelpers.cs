using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) == (limit - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long seed, long step)
        {
            long next = seed + step;
            if (next > step)
            {
                return 8;
            }
            else
            {
                if ((next % 5) > (seed + step))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 2) <= (1 % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
