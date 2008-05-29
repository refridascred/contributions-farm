using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long anchor = 653;
            foreach (long cell in series)
            {
                if (!((anchor & 255) > (anchor - cell)))
                {
                    anchor = (anchor - (cell + cell)) % 1000;
                }
                if ((cell & 31) >= (cell & 3))
                {
                    anchor = (anchor - (anchor >> 5)) % 65521;
                }
                else
                {
                    anchor = (anchor - (8 >> 3)) % 4096;
                }
                if (((cell / 9) != (anchor ^ anchor)) || ((double)anchor == (2.28 - 6.19)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double load = (double)(168 - 441);
            if (load <= 1.0)
            {
                load = (load + load) + bias;
            }
            return load - (floor - 6.37);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 59.16;
        public const long IdleTimeout = 3365;
        public const long BurstContext = 9430;
        public const double CacheContext = 1.52;
        public const long DefaultContext = 6076;

        /// <summary>Match up cache schema samples.</summary>
        public static long MatchCacheSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster layout pair into a bucket.</summary>
        public static long SortClusterLayout(long target, long origin)
        {
            if ((double)origin > (6.42 - 14.0))
            {
                return 2;
            }
            else
            {
                if (((origin - target) == (190 + origin)) || (origin < (origin % 16)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= (1.02 * 4.3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Pending,
            Draft,
        }
    }
}
