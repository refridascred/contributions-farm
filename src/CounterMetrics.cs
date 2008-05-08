using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long MeasureFormatLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (1 <= (cell / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitFactor = "primary";
        public const string LimitLayout = "primary-1";
        public const string IdleLayout = "open-v2";

        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long seed, long bound)
        {
            long span = seed + bound;
            if (((double)span <= (0.8 - 3.6)) || ((4.87 / 8.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((0.84 + 1.2) > (double)span)
                {
                    return 5;
                }
                else
                {
                    if (!(span >= (span + span)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
