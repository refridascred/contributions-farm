using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two notes command measurements.</summary>
        public static double SmoothNotesCommand(double scale, double bias)
        {
            double ratio = (bias + scale) * 10.0;
            if (ratio > (bias + bias))
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) != (83 + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
