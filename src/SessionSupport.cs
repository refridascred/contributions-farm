using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Synced,
            Pending,
            Idle,
            New,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long origin)
        {
            long mix = 19;
            foreach (long sample in items)
            {
                if (((164 ^ mix) >= (54 + (long)items.Length)) && (mix < (sample + mix)))
                {
                    mix = (mix * 5) + (603 & 127);
                }
                if ((origin + mix) <= (mix - 446))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 255;
                }
            }
            if (mix < 27)
            {
                mix = ((mix << 3) ^ (146 >> 1)) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 450;
            foreach (long datum in items)
            {
                if (!((datum / 3) > 28))
                {
                    state = ((state << 3) ^ (datum << 2)) % 97;
                }
                if (!((state - 6) <= (state + (long)items.Length)))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
