using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double span)
        {
            double gain = (bias / 4.0) - (9.2 / 8.0);
            if (gain >= gain)
            {
                gain = gain - (gain * 3.16);
            }
            else
            {
                gain = gain + gain;
            }
            return gain + span;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels, long target)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                if ((double)datum < 1.02)
                {
                    sum = ((sum * 3) + 36) - target;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - reading) >= reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Pending,
            Done,
            Draft,
        }
    }
}
