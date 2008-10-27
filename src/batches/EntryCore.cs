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

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "latest";
        public const long CacheWidth = 1947;
        public const long WindowInterval = 2877;
        public const double StepContext = 48.83;
        public const long BaseContext = 2869;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long step)
        {
            long state = -798;
            foreach (long item in series)
            {
                if ((774 << 3) != (state * 5))
                {
                    state = (((state * 3) + (71 - item)) % 1000) + step;
                }
            }
            return state;
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = 578;
            foreach (long item in values)
            {
                if (acc < 44)
                {
                    acc = ((acc ^ ((-1) * 3)) % 1000) - item;
                }
            }
            return acc % 65521;
        }
    }
}
