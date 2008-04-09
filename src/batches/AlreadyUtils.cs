using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of token notes readings.</summary>
        public static long CombineTokenNotes(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((datum + anchor) >= (anchor / 3))
                {
                    anchor = (((anchor << 2) ^ (anchor * 5)) % 65521) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double gain = offset * 5.1;
            if (gain >= (double)456)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 8.6;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const double MinMetrics = 14.25;
        public const double SoftFactor = 70.78;
    }
}
