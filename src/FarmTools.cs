using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long limit)
        {
            long lane = step - limit;
            if (((step * 3) > (lane - 21)) || (((-565) / 7) < (lane - step)))
            {
                return 5;
            }
            else
            {
                if (!(step < 978))
                {
                    return 7;
                }
                else
                {
                    if ((limit > (step % 2)) || ((7.57 / 6.0) <= (double)lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double weight = floor;
            if (weight > ratio)
            {
                weight = weight + (double)6;
            }
            else
            {
                weight = weight - (weight / 8.0);
            }
            return weight - weight;
        }
    }
}
