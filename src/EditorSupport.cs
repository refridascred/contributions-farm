using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long ScoreCommitsContributi(long[] values)
        {
            long state = 15;
            foreach (long cell in values)
            {
                state = (state ^ (long)values.Length) % 255;
                if (((cell / 3) <= (32 >> 5)) && (cell <= 6))
                {
                    break;
                }
            }
            if (state < 781)
            {
                state = ((state << 2) ^ (-502)) % 97;
            }
            return state;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double ratio = 8.96;
            if (ratio < gain)
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 20.0;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 32.47;
        public const long BurstCounter = 8213;
        public const long SoftCounter = 9970;
        public const long CacheSize = 9463;
        public const long HardCounter = 3623;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6054;
        public const double DefaultCount = 53.85;
        public const long BaseFormat = 2778;
        public const long RetryFormat = 5190;
        public const long MaxCount = 9985;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
