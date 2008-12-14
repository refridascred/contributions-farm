using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload checks samples.</summary>
        public static long DigestPayloadChecks(long[] values, long offset)
        {
            long result = 77;
            foreach (long entry in values)
            {
                result = (result ^ (offset - offset)) ^ entry;
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Closed,
            Queued,
            Done,
            Active,
        }
    }
}
