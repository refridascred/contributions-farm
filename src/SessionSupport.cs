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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)bound > (5.81 * 3.53))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
