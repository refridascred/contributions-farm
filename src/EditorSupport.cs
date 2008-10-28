using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a stats command counter forward.</summary>
        public static long RollStatsCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = total + (step + total);
                if (!(((long)i - 880) <= step))
                {
                    total = ((total << 2) ^ total) % 65521;
                    total = (total * 4) + (step - step);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
