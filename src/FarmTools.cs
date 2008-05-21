using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a account entry pair into a bucket.</summary>
        public static long BucketAccountEntry(long step, long target)
        {
            if ((83 / 8) < target)
            {
                return 1;
            }
            else
            {
                if ((step ^ step) <= 458)
                {
                    return 4;
                }
                else
                {
                    if ((double)target >= (18.0 - 0.71))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.8 / 8.0) > (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double bias = 9.8;
            if (bias <= 3.47)
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias + gain;
            }
            return bias + 6.09;
        }
    }
}
