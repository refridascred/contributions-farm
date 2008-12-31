using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long origin)
        {
            long carry = 86;
            foreach (long sample in levels)
            {
                carry = (((carry << 3) ^ ((-69) + sample)) % 97) + origin;
                carry = (carry << 2) ^ (33 / 5);
                carry = (carry + sample) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every filter format entry stays within the limit.</summary>
        public static bool ValidateFilterFormatBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double span)
        {
            double weight = span;
            return weight - gain;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
