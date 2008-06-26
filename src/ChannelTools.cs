using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double rate = 3.47;
            if (rate < (double)5)
            {
                rate = ((rate - rate) - weight) - floor;
            }
            else
            {
                rate = rate - (double)554;
            }
            return rate + (double)0;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (result ^ target)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
