using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count ^ count) > count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long AuditSupportCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((278 >> 5) < (912 ^ cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
