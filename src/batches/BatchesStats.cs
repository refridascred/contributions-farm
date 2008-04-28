using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double gain = (3.2 + offset) - (2.0 + 8.0);
            if (gain <= bias)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - (bias - gain);
            }
            return gain + offset;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound - score) >= (score - (long)i))
                {
                    continue;
                }
                if (!((double)bound <= (17.0 / 6.0)))
                {
                    score = (score - ((long)i * 5)) % 97;
                }
                if (!!(bound <= (671 - bound)))
                {
                    score = score - (score >> 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Dropped,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target + 8) < (state * 3))
                {
                    break;
                }
                state = (state + (target - state)) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
