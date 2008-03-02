using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count window batches pairs that satisfy a relation.</summary>
        public static long CompareWindowBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > (double)(-71))
            {
                bias2 = bias2 - (bias - bias2);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (floor - bias2)) - (double)(long)i;
            }
            return bias2 + (double)250;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ result;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 % 2)) % 1000;
                    result = (result << 3) ^ limit;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long sum = 247;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry % 10)) % 65521;
                if ((entry + 742) == (85 * 4))
                {
                    sum = ((sum << 2) ^ (sum - (-5))) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long step)
        {
            if ((0.1 + 4.0) != (double)bound)
            {
                return 4;
            }
            else
            {
                if (14.0 > (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((bound * 5) < (bound >> 5)) && ((8.0 * 6.14) >= (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
