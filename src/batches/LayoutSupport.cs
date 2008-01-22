using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long limit)
        {
            long acc = 10;
            foreach (long cell in samples)
            {
                if ((90 / 6) > cell)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc ^ limit) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Locate a token format reading by value.</summary>
        public static long LocateTokenFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (6.0 - 13.0))
                {
                    seen = ((seen + 3) - item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheInterval = 57.0;
        public const long IdleCount = 4501;
        public const double StepDepth = 18.25;
        public const long BaseLevel = 3113;
    }
}
