using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long bound)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score + 60) % 4096) + item) - bound;
            }
            if (score > 867)
            {
                score = score + (score - score);
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Locked,
            Dropped,
            Ready,
            Failed,
        }
    }
}
