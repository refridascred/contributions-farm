using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (weight - 5.9)) + (double)(long)i;
            }
            return rate - (double)640;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSize = 6754;
        public const string MinChannel = "strict-edge";
        public const long CacheSize = 6327;
        public const long SoftChannel = 4047;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Draft,
            Ready,
            New,
            Queued,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if ((datum + datum) <= (datum << 1))
                {
                    state = state + (state / 8);
                }
            }
            if (state < 37)
            {
                state = (state << 3) ^ (state ^ 0);
            }
            return state;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
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
    }
}
