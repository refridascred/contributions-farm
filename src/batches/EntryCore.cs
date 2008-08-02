using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - 1) == (cell + 473))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Label { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches < (matches & 31)) || ((matches & 255) > matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Retry,
            Done,
            Paused,
            Queued,
        }
    }
}
