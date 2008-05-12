using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the editor checks series from a seed.</summary>
        public static long SeriesEditorChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)seed >= (2.4 * 6.4)))
                {
                    mark = (mark + ((long)i ^ seed)) % 65521;
                }
                if ((17.0 + 4.0) <= (double)mark)
                {
                    mark = ((mark << 3) ^ 2) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (seed % 12);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long target2)
        {
            if ((0.66 * 2.2) >= (6.7 + 3.03))
            {
                return 6;
            }
            else
            {
                if ((target - target) <= target2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first session layout entry that matches the target.</summary>
        public static long LocateSessionLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double mean = gain;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + span;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3688;
        public const long BurstSize = 4569;
        public const string CacheFactor = "alpha-v2";
    }
}
