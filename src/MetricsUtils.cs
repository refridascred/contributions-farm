using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long FoldSupportProfile(long[] readings, long floor)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                if ((double)floor >= (6.7 / 6.0))
                {
                    mix = (((mix * 5) + 2) % 101) + reading;
                }
                if ((double)floor == (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Active,
            Dropped,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) <= (cell % 60))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
