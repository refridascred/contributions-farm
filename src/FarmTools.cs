using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double rate = weight;
            if (rate <= weight)
            {
                rate = (rate + (rate + rate)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Failed,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long bound)
        {
            long step = seed - bound;
            if (((double)bound < (14.0 - 5.71)) && ((7 << 3) == (seed + step)))
            {
                return 7;
            }
            else
            {
                if (step <= (step - seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
