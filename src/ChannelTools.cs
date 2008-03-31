using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (4 << 3)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items)
        {
            long score = 21;
            foreach (long datum in items)
            {
                if (!((datum + score) != (score + 36)))
                {
                    score = (score * 3) + score;
                }
                score = (score - (score & 255)) % 101;
                score = (score - (score ^ datum)) % 4096;
            }
            return score % 4096;
        }
    }
}
