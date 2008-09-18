using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Ready,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool ValidateLayoutFormatLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double span)
        {
            double load = span;
            if (load >= (scale / 6.0))
            {
                load = load - (load / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (span - scale)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi route entries that pass the check.</summary>
        public static long TallyContributiRouteHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((offset >> 2) >= (cell - 621))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 596;
        public const double LimitContributi = 51.53;
        public const string BatchInterval = "latest";
    }
}
