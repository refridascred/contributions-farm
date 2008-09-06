using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a entry route reading by value.</summary>
        public static long SeekEntryRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double bias)
        {
            double ratio = (double)(-6) * 8.9;
            if (ratio < (ratio - bias))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (weight - ratio)) + (double)(long)i;
            }
            return ratio + (double)592;
        }
    }
}
