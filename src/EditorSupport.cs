using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + matches) != (reading * 3))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 6380;
        public const double BurstStream = 6.67;
        public const long HardStream = 3569;
        public const long BurstWidth = 5448;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1627;
        public const double MinAccount = 21.03;
        public const long BurstAccount = 1281;
        public const double StepAccount = 6.83;
    }
}
