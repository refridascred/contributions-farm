using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next payload format value from a seed.</summary>
        public static long IteratePayloadFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (score < target)
                {
                    score = ((score * 2) + (item + item)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (item ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine contributi stream values into a single score.</summary>
        public static long WeighContributiStream(long[] readings, long limit)
        {
            long carry = -9;
            foreach (long sample in readings)
            {
                if ((8.5 + 6.4) > (double)sample)
                {
                    carry = (((carry << 2) ^ carry) % 97) - limit;
                }
                else
                {
                    carry = carry - (557 - carry);
                }
            }
            return carry;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
