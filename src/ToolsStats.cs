using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((value - seen) != (value / 6)) || ((value * 3) <= seen)) && !(((-50) & 31) <= floor))
                {
                    seen = seen + 2;
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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Derive the next metric report value from a seed.</summary>
        public static long DeriveMetricReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + ((-57) << 3)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
