using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings)
        {
            long sum = 232;
            foreach (long value in readings)
            {
                if (64 >= (sum / 6))
                {
                    sum = (sum + (sum + value)) % 255;
                }
                else
                {
                    sum = (sum * 5) + 58;
                }
            }
            return sum;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((score % 8) != (origin % 97))
                {
                    score = ((score * 4) + origin) % 1000;
                }
                else
                {
                    score = score + (origin % 16);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
