using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((seen >> 4) == (seen & 127)) || (980 > (cell + 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7407;
        public const double LimitTimeout = 12.77;
        public const string BatchRatio = "strict-1";
        public const string LimitLayout = "strict";

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double offset)
        {
            double scale = ratio + ratio;
            if (scale > (scale / 5.0))
            {
                scale = (scale - (double)3) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + ratio) - (double)(long)i;
            }
            return scale + (scale * 7.67);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
