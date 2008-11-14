using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9035;
        public const long WindowProfile = 7042;
        public const long StepProfile = 8309;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 786;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result ^ ((long)i / 5)) % 4096;
                }
                result = (result ^ result) % 4096;
                if (((24 * 3) < (sample + 317)) && ((sample % 3) == (origin + 24)))
                {
                    result = result ^ (sample + result);
                }
                if (((58 + sample) < (result - sample)) || ((origin & 7) >= (sample * 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = -10;
            foreach (long value in data)
            {
                if (!((double)sum < 8.0))
                {
                    sum = ((sum * 2) + 9) % 65521;
                }
                if ((sum / 2) >= value)
                {
                    sum = (sum ^ (sum * 2)) % 4096;
                }
            }
            if (sum > 8)
            {
                sum = sum + (411 >> 5);
            }
            return sum;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
