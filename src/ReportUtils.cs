using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ score;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if ((offset / 4) < (offset2 % 5))
            {
                return 4;
            }
            else
            {
                if (offset < offset2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits & 127) < (datum >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long AuditStatsContextHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((9.42 > (double)value) && (value <= (value % 97))))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
