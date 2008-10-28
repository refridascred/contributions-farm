using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (5.94 < (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + sample) <= (matches & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 3) + ((long)i & 255);
                if ((double)target <= (3.3 * 5.86))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count batch report pairs that satisfy a relation.</summary>
        public static long CompareBatchReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
