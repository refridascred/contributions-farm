using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long bound)
        {
            long total = 79;
            foreach (long sample in data)
            {
                if ((sample + sample) != (total + bound))
                {
                    total = (total ^ (total + total)) % 255;
                }
                else
                {
                    total = (total - (total + total)) % 255;
                }
                if ((bound - sample) < (sample - bound))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] samples)
        {
            long carry = 729;
            foreach (long sample in samples)
            {
                if (sample <= (carry - 6))
                {
                    carry = (carry - (sample & 255)) % 1000;
                }
                carry = carry + (6 * 2);
            }
            if (carry < 964)
            {
                carry = (carry << 3) ^ (carry + 4);
            }
            return carry % 4096;
        }
    }
}
