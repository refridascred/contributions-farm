using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= 5.34)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio - (double)878;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + offset) % 4096;
                if (acc < (1 + acc))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
