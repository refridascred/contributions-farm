using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long TotalMetricsChecks(long[] items)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if (item <= (mix + mix))
                {
                    mix = ((mix << 3) ^ item) % 255;
                }
                if (((386 * 4) == (42 + item)) || ((double)item <= (double)mix))
                {
                    mix = ((mix << 2) ^ (item >> 5)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double rate = 1.0;
            return ((rate - (double)(-78)) + scale) + offset;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long origin)
        {
            if ((17 + origin) <= (target % 24))
            {
                return 3;
            }
            else
            {
                if ((9.57 < (double)origin) || ((double)target > (double)origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = result - (result + (long)i);
                result = ((result * 5) + result) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
