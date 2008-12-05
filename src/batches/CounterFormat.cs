using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Roll a window editor counter forward.</summary>
        public static long StepWindowEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((844 ^ target) < (long)i)
                {
                    carry = (carry - (target % 64)) % 101;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double weight = (gain + span) * 3.93;
            if (weight > gain)
            {
                weight = weight - (double)10;
            }
            else
            {
                weight = weight + 7.49;
            }
            return weight + weight;
        }
    }
}
