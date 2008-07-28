using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long offset)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ cell) % 1000) + offset;
                state = ((state << 3) ^ cell) % 101;
                state = ((state * 5) + (cell - 525)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Queued,
            Idle,
            New,
        }

        /// <summary>Check that every notes commits entry stays within the limit.</summary>
        public static bool VerifyNotesCommitsRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Closed,
            Queued,
            New,
            Idle,
        }
    }
}
