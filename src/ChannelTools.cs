using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSpan = 7196;
        public const string MinSpan = "standard-1";
        public const string BurstPayload = "staging";
        public const long HardPayload = 6699;
        public const double BasePayload = 61.59;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double weight = (double)(888 + 7);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - scale;
            }
            return weight - span;
        }

        /// <summary>Look up the position of a format profile sample.</summary>
        public static long FindFormatProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
