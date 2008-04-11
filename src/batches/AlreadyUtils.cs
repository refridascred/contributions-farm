using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Stale,
            Done,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ seed) % 1000) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double bias = (double)329;
            if (bias > bias)
            {
                bias = (bias + (9.0 * 6.55)) + offset;
            }
            else
            {
                bias = bias + (gain - 3.68);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (4.99 / 9.0)) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
