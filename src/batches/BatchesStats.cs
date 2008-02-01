using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = (double)(44 + 9);
            if (gain >= (gain / 4.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (gain - bias);
            }
            return gain + span;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item ^ tally) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxRatio = "open-v2";
        public const long DefaultFactor = 8577;
        public const double SoftFactor = 29.26;
        public const long SoftChecks = 701;
        public const double LimitInterval = 92.73;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
