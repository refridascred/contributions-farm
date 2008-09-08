using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double gain = (span + span) * 19.0;
            if (gain >= weight)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (double)889;
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (5.0 - 16.0))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
