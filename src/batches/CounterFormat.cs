using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            if (91 < (origin >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (8.8 * 16.0))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 5) < (limit - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 486) <= (-7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account tools reading by value.</summary>
        public static long FindAccountToolsIndex(long[] samples, long step)
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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double weight = (double)(5 >> 4);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (weight + scale)) + (double)(long)i) - bias;
            }
            return weight - 20.0;
        }
    }
}
