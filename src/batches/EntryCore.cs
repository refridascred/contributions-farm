using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 4;
            foreach (long reading in readings)
            {
                anchor = ((anchor ^ anchor) % 4096) + reading;
            }
            return anchor % 97;
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
