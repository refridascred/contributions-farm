using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of farm record readings.</summary>
        public static long PairFarmRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long next = offset + limit;
            if ((double)offset <= (double)next)
            {
                return 5;
            }
            else
            {
                if (!((next ^ limit) < (limit + offset)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 2) ^ (origin & 1)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result - (origin & 127)) % 4096) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double span)
        {
            double load = gain;
            if (load <= (double)2)
            {
                load = (load - (gain / 8.0)) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 7.18) + (double)(long)i;
            }
            return load - (14.0 + 2.3);
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (4.16 < (double)seed)
            {
                return 2;
            }
            else
            {
                if (((966 & 3) < limit) || (5.13 > (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
