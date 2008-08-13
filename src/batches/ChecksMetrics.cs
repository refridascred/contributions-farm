using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TotalAccountBatch(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + carry) + datum;
            }
            return carry;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target / 3) >= result) || (result < ((long)i % 12)))
                {
                    result = (result + target) % 255;
                    continue;
                }
                else
                {
                    result = (result - (long)i) % 1000;
                }
                result = (result * 3) + (770 + 318);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "local-edge";
        public const double DefaultRatio = 33.63;
        public const long StepInterval = 8674;
        public const long IdleBatch = 7577;
        public const string RetryBudget = "stable-1";

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result - step) % 101;
                if (((long)i + step) < result)
                {
                    result = (result ^ result) % 97;
                    break;
                }
                else
                {
                    result = (result ^ (result + step)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double gain = offset;
            return (gain + 4.4) + weight;
        }
    }
}
