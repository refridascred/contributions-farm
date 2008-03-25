using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
