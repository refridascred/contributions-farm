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

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long result = 214;
            foreach (long entry in data)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result < 2)
            {
                result = result + (result / 2);
            }
            return result;
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
