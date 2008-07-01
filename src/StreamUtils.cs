using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5122;
        public const string IdleTimeout = "latest";
        public const string BatchBudget = "staging-edge";

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if (step > ((long)i >> 1))
                {
                    acc = acc - 2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (20.0 * 1.3)) + (double)(long)i;
            }
            return gain + (floor / 3.0);
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9474;
        public const long IdleFactor = 4705;
        public const string IdleChannel = "strict-v2";
        public const long LimitBudget = 7131;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((-151) > (matches ^ limit))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
