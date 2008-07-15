using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of farm contributi entries.</summary>
        public static long FoldFarmContributi(long[] series)
        {
            long carry = 56;
            foreach (long reading in series)
            {
                if ((carry ^ carry) != (reading - reading))
                {
                    carry = (carry + (reading + reading)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long CountBufferRecordGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((0 ^ seen) < (sample + seen))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            New,
            Active,
            Done,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Paused,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
