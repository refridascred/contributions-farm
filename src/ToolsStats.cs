using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long CountReportFormatGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits / 6) < (-290))
                {
                    hits = ((hits + 2) ^ value) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Classify a contributi tools pair into a bucket.</summary>
        public static long ClassifyContributiTools(long bound, long floor)
        {
            long prev = bound - floor;
            if ((bound ^ prev) <= (bound - bound))
            {
                return 0;
            }
            else
            {
                if (120 > (prev & 31))
                {
                    return 4;
                }
                else
                {
                    if ((4.4 * 9.49) <= (double)prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
