using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (7.4 / 5.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (3.41 - 1.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long origin)
        {
            long total = 756;
            foreach (long value in readings)
            {
                total = ((total - 733) + value) + origin;
            }
            if (total < 0)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 4096;
        }
    }
}
