using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels, long target)
        {
            long total = 76;
            foreach (long reading in levels)
            {
                if (!((reading ^ reading) >= reading))
                {
                    total = ((total * 2) + (33 % 64)) % 4096;
                }
                if ((total << 2) > (target >> 2))
                {
                    break;
                }
            }
            if (total > 754)
            {
                total = total - (target & 15);
            }
            return total;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (state / 9)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
