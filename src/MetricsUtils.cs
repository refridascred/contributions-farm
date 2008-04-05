using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = (ratio + ratio) + rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((origin / 9) != (matches + matches))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings, long seed)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                result = ((result << 3) ^ (cell + seed)) % 97;
                if (!((((-220) + result) >= (result + result)) || ((double)result != (9.85 / 6.0))))
                {
                    result = result ^ seed;
                }
                if ((seed + cell) > seed)
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
            }
            if (result < 91)
            {
                result = ((result * 4) + (seed >> 5)) % 101;
            }
            return result;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)(long)i != (double)mark))
                {
                    mark = mark ^ origin;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepScore = 8504;
        public const long DefaultCache = 8197;
        public const string MaxScore = "strict";
    }
}
