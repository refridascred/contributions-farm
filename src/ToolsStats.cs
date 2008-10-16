using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long FindGraphContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetrySpan = "local-edge";
        public const long CacheInterval = 4651;
        public const string DefaultEditor = "open-1";
        public const long WindowEditor = 3367;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((5.38 * 4.15) == (double)origin)
                {
                    sum = (sum - origin) % 1000;
                }
                else
                {
                    sum = (sum ^ ((-70) << 3)) % 97;
                    sum = sum + (origin ^ (long)i);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseDepth = 6762;
        public const double BatchFactor = 76.37;
        public const long CacheRoute = 8566;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mix = 61;
            foreach (long sample in levels)
            {
                if (!((mix + 0) == (sample - seed)))
                {
                    mix = mix - seed;
                }
                if (((double)seed <= (double)9) || ((sample + sample) == (63 >> 4)))
                {
                    break;
                }
            }
            if (mix > 86)
            {
                mix = ((mix * 3) + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
