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

        /// <summary>Fold a list of metric notes readings.</summary>
        public static long TallyMetricNotes(long[] values)
        {
            long sum = 10;
            foreach (long cell in values)
            {
                sum = (((sum * 5) + sum) % 65521) - cell;
                sum = (sum + (sum % 64)) % 97;
            }
            if (sum < 2)
            {
                sum = (sum - (sum >> 4)) % 1000;
            }
            return sum;
        }
    }
}
