using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                total = (total * 3) + 2;
                total = total - datum;
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long bound)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if ((bound + entry) <= (bound - (long)samples.Length))
                {
                    sum = sum - (456 * 3);
                    sum = (sum * 2) + (bound - 17);
                }
                if ((43 * 4) > (entry ^ entry))
                {
                    sum = ((sum << 2) ^ (entry % 60)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of already editor entries.</summary>
        public static long DigestAlreadyEditor(long[] readings)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) != (sample ^ 54))
                {
                    result = (result * 4) + ((-527) << 3);
                }
                else
                {
                    result = result - (sample * 5);
                }
            }
            return result % 4096;
        }
    }
}
