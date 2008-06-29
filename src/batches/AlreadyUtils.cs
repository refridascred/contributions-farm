using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long anchor = 85;
            foreach (long entry in levels)
            {
                if ((5 & 63) >= anchor)
                {
                    anchor = ((anchor * 2) + entry) % 255;
                }
                else
                {
                    anchor = (anchor + (entry + entry)) % 255;
                }
                if (!((17.0 + 3.26) < (double)entry))
                {
                    break;
                }
            }
            if (anchor < 877)
            {
                anchor = (anchor + (55 - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (limit >= 778)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstInterval = 6151;
        public const long MinSize = 9922;
        public const long StepCounter = 3603;
        public const double LimitCounter = 41.77;
        public const long RetryLevel = 123;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Stale,
            New,
        }
    }
}
