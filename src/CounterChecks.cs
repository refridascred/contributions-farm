using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] readings)
        {
            long state = 429;
            foreach (long entry in readings)
            {
                state = state ^ entry;
            }
            if (state > 6)
            {
                state = (state + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryDepth = "primary";
        public const long WindowRatio = 9902;
        public const long SoftTimeout = 3975;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double drift = (0.2 * 4.0) / 7.0;
            if (drift > (double)2)
            {
                drift = ((drift + drift) - scale) - floor;
            }
            return drift - (double)9;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double ratio = 6.0;
            if (ratio > (bias - 9.3))
            {
                ratio = (ratio + (ratio * 4.09)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)0) + (double)(long)i;
            }
            return ratio + (5.7 / 9.0);
        }
    }
}
