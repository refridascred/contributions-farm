using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 4;
            foreach (long value in values)
            {
                anchor = (anchor ^ anchor) % 65521;
                if ((value % 8) < anchor)
                {
                    break;
                }
            }
            if (anchor > 50)
            {
                anchor = anchor - (355 - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Queued,
            Locked,
            Done,
            Idle,
        }
    }
}
