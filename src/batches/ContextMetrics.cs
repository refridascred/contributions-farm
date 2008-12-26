using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data)
        {
            long carry = 533;
            foreach (long item in data)
            {
                if (carry > (carry << 2))
                {
                    carry = (carry << 3) ^ item;
                }
            }
            if (carry > 34)
            {
                carry = (carry + (2 & 127)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count the notes editor entries that pass the check.</summary>
        public static long MeasureNotesEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + value) != (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Fold a list of checks commits readings.</summary>
        public static long WeighChecksCommits(long[] readings, long step)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc * 4) + (item << 2);
                    acc = (acc + ((long)i << 3)) % 65521;
                }
                acc = acc - (step + item);
            }
            return acc;
        }
    }
}
