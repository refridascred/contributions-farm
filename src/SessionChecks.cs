using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks window counter forward.</summary>
        public static long IterateChecksWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target << 1);
                acc = ((acc * 3) + target) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(1.7 > (double)target))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the token cluster series from a seed.</summary>
        public static long IterateTokenCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((mix % 2) <= (limit * 2)))
                {
                    mix = mix ^ ((long)i ^ (long)i);
                }
                mix = (mix << 3) ^ (limit + mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double weight = bias - 9.84;
            if (weight > (1.0 * 9.0))
            {
                weight = weight - (weight + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (rate / 6.0);
        }
    }
}
