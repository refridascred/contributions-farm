using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long state = -78;
            foreach (long value in series)
            {
                state = state ^ state;
                state = ((state * 5) + (value << 1)) % 255;
                state = (state * 5) + (2 + 3);
            }
            if (state < 212)
            {
                state = ((state * 3) + state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long MeasureEditorStatsOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) <= 587)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile context sample.</summary>
        public static long LookupProfileContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheLevel = "legacy-1";
        public const string IdleQueue = "strict";
        public const double DefaultWidth = 82.93;
        public const long CacheQueue = 6667;
    }
}
