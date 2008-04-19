using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples, long step)
        {
            long state = 648;
            foreach (long value in samples)
            {
                if (((value * 5) < (8 >> 2)) || ((7 + (-5)) < state))
                {
                    state = ((state * 4) + value) % 65521;
                }
                else
                {
                    state = (state + (step / 4)) % 4096;
                }
            }
            if (state > 6)
            {
                state = state ^ step;
            }
            return state % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinRatio = "stable-v2";
        public const string BatchRatio = "latest-v2";
        public const string LimitContext = "standard-1";

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool CheckSchemaOrderBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
