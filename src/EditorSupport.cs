using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long CountContextSessionOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches == (8.9 / 5.0))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
