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

        /// <summary>Project the next payload command value.</summary>
        public static double BlendPayloadCommand(double scale, double floor)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = (drift + (drift * 6.36)) - floor;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift * 3.92);
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
