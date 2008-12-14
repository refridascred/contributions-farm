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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
