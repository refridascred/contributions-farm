using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data, long target)
        {
            long mark = 343;
            foreach (long sample in data)
            {
                if (((target / 6) <= mark) && ((mark % 8) >= (sample & 31)))
                {
                    mark = (mark ^ (sample ^ 55)) % 101;
                    break;
                }
                else
                {
                    mark = ((mark * 5) + (target * 3)) % 4096;
                    mark = (mark << 2) ^ 763;
                }
                mark = ((mark * 4) + (sample >> 1)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "latest";
        public const long BaseFactor = 6312;
        public const long IdleContributi = 9042;
        public const long BurstContributi = 3679;
    }
}
