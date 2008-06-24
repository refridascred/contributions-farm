using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Done,
            New,
            Retry,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long origin)
        {
            long carry = -64;
            foreach (long sample in values)
            {
                if (origin >= (carry / 4))
                {
                    carry = (carry + (sample + 62)) % 255;
                }
            }
            if (carry > 0)
            {
                carry = ((carry * 3) + (8 >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long ScoreRecordLayout(long[] levels)
        {
            long result = -582;
            foreach (long entry in levels)
            {
                result = (result - (568 + result)) ^ entry;
            }
            return result % 65521;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
