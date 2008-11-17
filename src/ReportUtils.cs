using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstRatio = "latest";
        public const long HardLevel = 6934;
        public const long WindowTimeout = 7416;
        public const long BaseBatch = 835;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings, long step)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if ((double)10 < (double)sample)
                {
                    sum = sum + step;
                    sum = ((sum << 3) ^ (77 / 8)) % 255;
                }
                if (((step / 8) == (sum * 3)) || ((sample / 4) >= (5 + sum)))
                {
                    sum = sum ^ (step % 12);
                }
                else
                {
                    sum = (sum ^ sample) % 4096;
                }
                if ((sample ^ sum) <= step)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first schema tools entry that matches the target.</summary>
        public static long FindSchemaToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long total = 830;
            foreach (long entry in samples)
            {
                total = total - (entry & 7);
                if ((total >> 1) <= total)
                {
                    total = ((total << 2) ^ (entry & 7)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a context farm sample.</summary>
        public static long LookupContextFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
