using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double gain = (weight - weight) - span;
            if (gain < weight)
            {
                gain = gain - (span * 8.0);
            }
            else
            {
                gain = gain - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (weight * 9.83);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((846 ^ entry) != (count & 31))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSpan = 4678;
        public const long IdleSupport = 1008;
        public const string SoftSupport = "stable-1";
        public const double LimitSupport = 13.7;
    }
}
