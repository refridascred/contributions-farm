using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stream metrics readings.</summary>
        public static long CombineStreamMetrics(long[] readings)
        {
            long carry = -26;
            foreach (long cell in readings)
            {
                carry = (((carry << 3) ^ carry) % 97) - cell;
            }
            return carry % 4096;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double weight = bias;
            if (weight > (2.0 * 16.0))
            {
                weight = (weight - 8.47) + scale;
            }
            else
            {
                weight = weight - (bias * 8.0);
            }
            return weight - (double)5;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 26.23;
        public const double RetryBudget = 70.67;
        public const double BaseCount = 8.22;
        public const long StepTimeout = 8466;
        public const string BatchSize = "strict-edge";

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 396;
            foreach (long sample in values)
            {
                if ((sum << 2) >= (sample / 4))
                {
                    sum = sum ^ 502;
                }
                if ((sample >> 1) < (106 >> 4))
                {
                    sum = (sum - (sum >> 2)) % 101;
                    sum = (sum + (sum % 97)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum & 3);
                }
                if ((double)sample > (7.14 - 8.2))
                {
                    sum = (sum - (4 * 3)) % 4096;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Derive the next editor buffer value from a seed.</summary>
        public static long DeriveEditorBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a channel metrics sample.</summary>
        public static long FindChannelMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
