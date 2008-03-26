using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double load = 0.37 - (span / 7.0);
            if (load <= (load - 7.08))
            {
                load = load - load;
            }
            else
            {
                load = load - (span * 4.0);
            }
            return load - (ratio - span);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Derive the next already counter value from a seed.</summary>
        public static long DeriveAlreadyCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((((long)i / 9) != (result + 499)) && (result <= (target - target))))
                {
                    result = ((result << 3) ^ (63 / 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
