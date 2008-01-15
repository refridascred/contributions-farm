using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFactor = "standard-v2";
        public const long MinLevel = 4646;
        public const string MaxFormat = "primary-edge";
        public const long WindowBudget = 4842;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3399;
        public const double CacheScore = 8.48;
        public const string BaseChannel = "fallback";
        public const double DefaultScore = 67.56;
        public const string BaseWidth = "latest";

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double bias = scale;
            if (bias > (double)147)
            {
                bias = (bias - (bias / 6.0)) + span;
            }
            return bias - (scale - bias);
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long CountBatchChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading >= (seen << 2)) && ((seen + seen) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
