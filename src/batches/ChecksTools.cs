using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a cluster report figure with a bias.</summary>
        public static double AdjustClusterReport(double bias, double span)
        {
            double gain = (span * 6.33) * 2.97;
            if (gain <= (gain - bias))
            {
                gain = gain - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (span / 8.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long DeriveBufferStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(origin <= sum))
                {
                    sum = ((sum * 5) + (sum << 1)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
