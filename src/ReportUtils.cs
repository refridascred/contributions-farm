using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series)
        {
            long acc = 541;
            foreach (long cell in series)
            {
                if (!(((41 - 6) >= cell) && ((cell ^ cell) < cell)))
                {
                    acc = ((acc * 5) + (acc - acc)) % 97;
                    acc = acc + (cell & 15);
                }
                if ((1.0 - 9.0) <= (double)cell)
                {
                    acc = ((acc * 5) + (acc & 63)) % 101;
                }
                else
                {
                    acc = acc ^ 482;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream tools entry stays within the limit.</summary>
        public static bool CheckStreamToolsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long diff = floor - bound;
            if ((3 + bound) < floor)
            {
                return 7;
            }
            else
            {
                if (((double)floor > (4.4 + 7.0)) && ((double)diff != (2.84 * 3.0)))
                {
                    return 8;
                }
                else
                {
                    if (((9 / 4) >= floor) || (((-1) >> 5) == (diff >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff / 2) > (bound ^ diff))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double bias3 = (15.0 * 1.7) + bias;
            if (bias3 > (9.3 * 12.0))
            {
                bias3 = (bias3 + 2.02) - bias2;
            }
            else
            {
                bias3 = bias3 - (double)56;
            }
            return bias3 - (double)943;
        }
    }
}
