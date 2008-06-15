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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
