using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count * 2) != (count / 2))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first editor buffer entry that matches the target.</summary>
        public static long LookupEditorBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Pending,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxLevel = 43.69;
        public const string IdleCommand = "alpha";
        public const string MaxCommand = "legacy-1";
        public const long SoftCommand = 2132;
    }
}
