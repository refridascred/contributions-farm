using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long bound)
        {
            long slot = limit - bound;
            if ((7.47 < (double)bound) && ((limit * 3) <= 8))
            {
                return 6;
            }
            else
            {
                if ((slot <= (403 % 5)) && ((slot ^ limit) <= ((-4) + slot)))
                {
                    return 3;
                }
                else
                {
                    if ((slot + 710) > (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot << 2) > (limit - 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor command figure with a bias.</summary>
        public static double ProjectEditorCommand(double gain, double offset)
        {
            double bias = (offset * 7.0) / 8.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)(long)i) + gain;
            }
            return bias - (6.8 * 8.9);
        }
    }
}
