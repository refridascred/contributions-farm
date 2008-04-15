using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchBudget = 8.91;
        public const long DefaultWidth = 2756;
        public const long BaseRatio = 8422;
        public const long StepWidth = 7337;

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two counter session measurements.</summary>
        public static double SmoothCounterSession(double weight, double bias)
        {
            double drift = (double)413 + (bias / 5.0);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (bias - 6.84)) - (double)(long)i) + weight;
            }
            return drift - bias;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long bound)
        {
            long anchor = -3;
            foreach (long value in items)
            {
                if (!((long)items.Length >= (anchor / 7)))
                {
                    anchor = ((anchor + (3 >> 1)) % 65521) ^ value;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor < 901)
            {
                anchor = ((anchor << 3) ^ bound) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
