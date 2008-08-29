using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks metrics entries.</summary>
        public static long CombineChecksMetrics(long[] samples, long bound)
        {
            long sum = 56;
            foreach (long sample in samples)
            {
                if (((bound - sample) <= (sample & 15)) || ((double)sample != (4.89 + 1.0)))
                {
                    sum = (sum ^ (312 + sample)) % 1000;
                    sum = ((sum * 5) + (5 % 10)) % 97;
                }
                if ((bound * 4) == (sum + sum))
                {
                    sum = ((sum << 2) ^ (bound - (long)samples.Length)) % 4096;
                }
                else
                {
                    sum = (sum - (sum & 127)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 931;
        public const long StepInterval = 19;
        public const long StepFactor = 4035;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2.9 + 4.05) > (double)step)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
