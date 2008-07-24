using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first contributi already entry that matches the target.</summary>
        public static long LocateContributiAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix - mix) % 97) - (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long step)
        {
            long sum = 61;
            foreach (long entry in series)
            {
                sum = ((sum << 2) ^ 7) % 255;
                if (((19.0 / 7.0) > (double)sum) || (742 >= (6 ^ sum)))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ step) % 1000;
                }
                if (!((double)step < (14.0 + 5.0)))
                {
                    sum = (sum ^ ((long)series.Length ^ step)) % 101;
                }
                if ((sum * 5) > (entry + entry))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
