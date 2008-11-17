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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= 1.4)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
