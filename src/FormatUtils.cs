using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 69;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ (sum + cell);
                sum = ((sum << 2) ^ (cell & 63)) % 97;
            }
            if (sum > 6)
            {
                sum = sum + (sum >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double ratio2 = 0.95;
            if (ratio2 < (floor + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 + 5.94)) - ratio;
            }
            return ratio2 - (floor / 2.0);
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Retry,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Count stream cluster pairs that satisfy a relation.</summary>
        public static long MatchStreamClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double scale = 7.79 + (bias2 * 0.35);
            if (scale < bias2)
            {
                scale = (scale + scale) - bias;
            }
            return scale + (double)0;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long value in levels)
            {
                sum = ((sum + (sum - sum)) + value) + bound;
            }
            if (sum < 4)
            {
                sum = sum ^ (sum / 9);
            }
            return sum;
        }
    }
}
