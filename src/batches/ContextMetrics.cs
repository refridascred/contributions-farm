using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long TallyStreamAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum >= (709 / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples, long floor)
        {
            long sum = 3;
            foreach (long sample in samples)
            {
                if ((floor >> 2) >= (sum << 2))
                {
                    sum = (sum + (sum / 7)) % 97;
                }
                else
                {
                    sum = (sum * 5) + (95 + sample);
                }
            }
            return sum;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + 50) >= ((-1) % 12))
                {
                    result = ((result << 3) ^ (28 + seed)) % 4096;
                    break;
                }
                else
                {
                    result = ((result << 3) ^ seed) % 97;
                    result = (result - (0 + result)) % 4096;
                }
                result = (result + ((long)i ^ seed)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double bias)
        {
            double rate = weight / 7.0;
            if (rate < weight)
            {
                rate = rate - weight;
            }
            return rate + (bias * 7.0);
        }
    }
}
