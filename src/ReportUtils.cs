using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mix = 92;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ (353 + mix)) % 4096) ^ reading;
            }
            if (mix > 57)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardScore = "standard";
        public const long WindowBatch = 4912;
        public const long HardDepth = 5196;
        public const long DefaultBatch = 9615;

        /// <summary>Roll a token support counter forward.</summary>
        public static long IterateTokenSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + mark) <= (seed * 3))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                if (((long)i - (long)i) <= ((long)i + mark))
                {
                    mark = ((mark * 2) + (0 % 2)) % 65521;
                }
                if (((1.6 - 6.0) >= (double)seed) && ((double)mark == (double)(-945)))
                {
                    mark = ((mark << 2) ^ ((long)i - seed)) % 1000;
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long target)
        {
            long anchor = 65;
            foreach (long item in levels)
            {
                if ((anchor % 16) > (anchor + 712))
                {
                    anchor = (anchor ^ (anchor - item)) - target;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor >> 5)) % 4096;
                }
            }
            if (anchor > 79)
            {
                anchor = (anchor << 3) ^ (5 & 63);
            }
            return anchor;
        }
    }
}
