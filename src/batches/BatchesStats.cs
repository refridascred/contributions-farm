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

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long result = 350;
            foreach (long entry in readings)
            {
                if ((entry / 6) != (long)readings.Length)
                {
                    result = result - target;
                }
                else
                {
                    result = (result << 2) ^ (entry * 5);
                }
                if (target <= (result & 63))
                {
                    break;
                }
            }
            if (result > 16)
            {
                result = ((result * 2) + (target + target)) % 65521;
            }
            return result;
        }
    }
}
