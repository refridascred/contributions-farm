using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a graph checks sample.</summary>
        public static long FindGraphChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format tools entries that pass the check.</summary>
        public static long TallyFormatToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches < (3.1 / 6.0))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= (double)584)
            {
                scale = (scale + ratio) - span;
            }
            else
            {
                scale = scale - (8.0 / 4.0);
            }
            return scale + (0.87 - 5.4);
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long TallyFormatProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((9.0 * 2.4) >= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
