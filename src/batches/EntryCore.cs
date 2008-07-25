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

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Stale,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            if ((floor << 3) <= (seed + floor))
            {
                return 1;
            }
            else
            {
                if (floor >= seed)
                {
                    return 6;
                }
                else
                {
                    if (!((floor - seed) <= (floor & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
