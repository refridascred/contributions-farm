using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two commits account measurements.</summary>
        public static double AdjustCommitsAccount(double weight, double offset)
        {
            double rate = (double)3 - (double)9;
            return ((rate + (double)7) + weight) + offset;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the window batch series from a seed.</summary>
        public static long DeriveWindowBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches & 7) <= 6)
                {
                    matches = ((matches + 2) ^ entry) + target;
                }
            }
            return matches;
        }
    }
}
