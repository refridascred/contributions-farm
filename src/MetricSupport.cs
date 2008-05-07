using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((cell >> 1) >= (matches ^ 90)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window session value from a seed.</summary>
        public static long RollWindowSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                long seen = origin;
                if (((63 * 4) >= (state << 3)) || ((origin ^ origin) != (seen + origin)))
                {
                    state = (state - origin) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i - origin)) % 65521;
                    seen = (seen * 2) + (seen % 60);
                }
                state = ((state << 3) ^ (state + 68)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long bound2)
        {
            if ((99 / 9) != (bound2 * 5))
            {
                return 2;
            }
            else
            {
                if (bound > (bound2 - bound2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
