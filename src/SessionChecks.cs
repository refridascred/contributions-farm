using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)target != (8.58 - 4.27))
                {
                    result = result ^ (result << 2);
                    result = result ^ (1 & 255);
                }
                result = result - ((long)i * 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double weight = (double)409 * 0.2;
            if (weight < 12.0)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (3.46 - offset)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] values)
        {
            long result = 540;
            foreach (long datum in values)
            {
                result = (result + (result + result)) % 4096;
                if ((double)datum >= (double)result)
                {
                    result = (result ^ (result + datum)) % 1000;
                }
            }
            if (result < (-71))
            {
                result = (result + (result >> 4)) % 4096;
            }
            return result;
        }
    }
}
