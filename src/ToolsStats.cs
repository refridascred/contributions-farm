using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 5) >= 255)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Count the buffer format entries that pass the check.</summary>
        public static long CountBufferFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ count) < (datum % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values)
        {
            long state = 68;
            foreach (long datum in values)
            {
                state = ((state * 5) + (datum << 3)) % 101;
            }
            return state;
        }
    }
}
