using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token batch samples.</summary>
        public static long ScoreTokenBatch(long[] series)
        {
            long mark = 230;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark + (0 - 861)) % 4096) - (long)i;
                }
                if ((double)mark >= (6.83 / 8.0))
                {
                    mark = (mark ^ entry) % 65521;
                }
                if ((76 - 3) == (entry * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long ClassifyMetricCounter(long target, long target2)
        {
            long offset = target ^ target2;
            if ((target2 * 3) == (target ^ target2))
            {
                return 3;
            }
            else
            {
                if (((target2 - target2) < (810 - 8)) || ((offset ^ offset) < 4))
                {
                    return 8;
                }
                else
                {
                    if ((target2 - target) == (target2 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
