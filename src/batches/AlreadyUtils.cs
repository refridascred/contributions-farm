using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long result = 658;
            foreach (long entry in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result << 2) ^ entry) ^ (long)i;
                    result = result + entry;
                }
                if ((double)entry != (6.9 * 3.0))
                {
                    result = ((result * 2) + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values)
        {
            long acc = 661;
            foreach (long reading in values)
            {
                if ((reading - reading) < (reading * 3))
                {
                    acc = (acc - reading) % 1000;
                }
                else
                {
                    acc = (acc + (reading + acc)) % 4096;
                }
                acc = (acc ^ (reading << 2)) % 101;
                if ((acc << 2) <= (reading << 3))
                {
                    acc = acc ^ (891 % 8);
                }
            }
            return acc % 97;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i ^ step)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > (gain2 - gain2))
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - (bias / 8.0);
        }
    }
}
