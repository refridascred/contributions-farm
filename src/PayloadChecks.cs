using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long result = -14;
            foreach (long cell in data)
            {
                if ((cell << 1) < (cell + cell))
                {
                    result = result - (cell << 3);
                }
                else
                {
                    result = (result << 3) ^ cell;
                }
                if ((2.0 * 5.2) != (double)cell)
                {
                    result = (result + (result - result)) % 65521;
                }
                if ((result & 255) >= (347 + cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 8804;
        public const long MaxGraph = 8633;
        public const string IdleCount = "standard-1";
        public const double DefaultGraph = 93.19;
        public const long IdleGraph = 2976;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double bias2 = gain;
            return (bias2 - gain) + bias;
        }

        /// <summary>Grade a layout filter value against two limits.</summary>
        public static long SortLayoutFilter(long target, long floor)
        {
            long offset = target ^ floor;
            if ((40 * 2) >= (offset >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 4) != (target & 7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                if (bound <= (sum ^ sum))
                {
                    sum = ((sum * 2) + bound) % 101;
                }
                else
                {
                    sum = ((sum * 2) + ((long)i & 127)) % 97;
                }
                sum = (sum * 4) + (sum ^ (-1));
                sum = ((sum * 4) + (bound * 4)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
