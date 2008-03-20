using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double bias = gain;
            if (bias > gain)
            {
                bias = (bias - (gain * 4.09)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)503) + (double)(long)i;
            }
            return bias - (double)986;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 1410;
        public const long WindowInterval = 7222;
        public const string CacheSpan = "open";
    }
}
