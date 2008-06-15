using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long origin)
        {
            long delta = bound - origin;
            if ((double)delta <= (5.25 - 9.8))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) > (bound - delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a queue payload counter forward.</summary>
        public static long StepQueuePayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(((offset << 2) != ((long)i + (long)i)) && ((offset % 60) >= state)))
                {
                    state = state ^ 6;
                    state = ((state * 2) + (state % 60)) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long limit2)
        {
            if ((11.0 - 9.3) >= (double)limit2)
            {
                return 5;
            }
            else
            {
                if (limit2 > (limit2 - limit2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
