using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = score + 87;
                if (((value / 2) > (value << 3)) || ((2 ^ score) < (value ^ (-6))))
                {
                    score = (score * 4) + 14;
                }
            }
            return score;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 749;
            foreach (long sample in data)
            {
                total = (total << 3) ^ sample;
                if (736 <= sample)
                {
                    total = (total * 3) + (43 % 16);
                }
            }
            return total;
        }
    }
}
