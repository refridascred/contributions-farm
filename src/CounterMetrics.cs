using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxFactor = 43.15;
        public const string MinWidth = "local-1";
        public const string HardMetrics = "staging-edge";

        /// <summary>Blend two cache checks measurements.</summary>
        public static double ProjectCacheChecks(double rate, double bias)
        {
            double drift = (double)((-315) ^ 3);
            if (drift < (rate - drift))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift - 7.78);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data)
        {
            long mix = 611;
            foreach (long value in data)
            {
                if (!((double)mix == (1.0 - 0.03)))
                {
                    mix = (mix << 2) ^ value;
                }
                if ((value ^ mix) >= 3)
                {
                    mix = (mix - (mix + mix)) % 4096;
                }
            }
            return mix;
        }
    }
}
