using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Queued,
            New,
            Pending,
            Paused,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate command contributi readings against a bound.</summary>
        public static bool GuardCommandContributiLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
