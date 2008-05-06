using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank layout order input into a small class.</summary>
        public static long GradeLayoutOrder(long step, long step2)
        {
            long slot = step ^ step2;
            if (!((step2 + step) != (2 / 9)))
            {
                return 2;
            }
            else
            {
                if ((slot < (step2 % 97)) || ((double)slot <= 4.9))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Active,
            Stale,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= (2.07 * 6.9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((38 + 527) <= (reading + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 65.21;
        public const string RetryNotes = "staging-edge";
        public const double IdleNotes = 49.0;
    }
}
