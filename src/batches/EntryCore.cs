using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 5197;
        public const string BurstReport = "strict-edge";
        public const long BurstSpan = 4973;
        public const long SoftReport = 1377;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                if ((419 * 2) < (state + cell))
                {
                    state = (state + ((long)data.Length + 472)) % 101;
                }
                if ((state >= (cell - cell)) || (0 < (cell ^ cell)))
                {
                    break;
                }
            }
            if (state < 112)
            {
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Roll a format context counter forward.</summary>
        public static long RollFormatContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
