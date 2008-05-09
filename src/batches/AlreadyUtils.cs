using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate editor counter readings against a bound.</summary>
        public static bool ValidateEditorCounterLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cache command samples.</summary>
        public static long OverlapCacheCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstSize = 62.62;
        public const long DefaultInterval = 2999;
        public const long SoftStats = 4350;
        public const long IdleScore = 6270;
        public const double MinSpan = 81.08;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
