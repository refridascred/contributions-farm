using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already profile samples.</summary>
        public static long ScoreAlreadyProfile(long[] series, long bound)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score + cell) >= (score + bound))
                {
                    score = (score ^ (cell & 127)) % 65521;
                }
                else
                {
                    score = (score ^ (score ^ bound)) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] samples, long step)
        {
            long state = 34;
            foreach (long entry in samples)
            {
                if ((double)state > 4.0)
                {
                    state = ((state * 4) + (step - state)) ^ entry;
                }
                else
                {
                    state = ((state * 3) + (92 + step)) % 1000;
                }
                state = state - ((long)samples.Length + step);
            }
            return state % 1000;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long origin)
        {
            long edge = step ^ origin;
            if (((9.89 / 7.0) < (double)edge) || ((edge + edge) > (edge / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin - step) <= (edge - origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two session command measurements.</summary>
        public static double AdjustSessionCommand(double scale, double offset)
        {
            double bias = (18.0 / 6.0) * 19.0;
            if (bias > bias)
            {
                bias = (bias - offset) - scale;
            }
            return bias - offset;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 46.92;
        public const long BurstScore = 2425;
        public const double LimitSession = 18.58;
        public const long StepSession = 1674;
        public const long IdleBudget = 2539;
    }
}
