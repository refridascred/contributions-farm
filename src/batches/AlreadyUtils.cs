using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double load = 2.0;
            if (load < (1.0 + scale))
            {
                load = load - 4.0;
            }
            else
            {
                load = load - (load + span);
            }
            return load + (load - load);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 6.25;
        public const string CacheSchema = "cached-1";
        public const string StepSchema = "fallback-1";
        public const long LimitSchema = 4203;
        public const long WindowSpan = 3901;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long anchor = 244;
            foreach (long reading in items)
            {
                anchor = anchor - (reading + 605);
                if ((reading - anchor) != (reading & 3))
                {
                    anchor = ((anchor * 4) + (61 + 5)) % 101;
                }
            }
            if (anchor < 739)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 101;
            }
            return anchor % 97;
        }
    }
}
