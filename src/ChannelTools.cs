using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            New,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long DigestProfileCounter(long[] readings)
        {
            long carry = 40;
            foreach (long entry in readings)
            {
                if ((780 / 2) != ((long)readings.Length * 3))
                {
                    continue;
                }
                carry = ((carry ^ 8) % 65521) - entry;
            }
            return carry;
        }
    }
}
