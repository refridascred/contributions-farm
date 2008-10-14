using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Retry,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Roll a batches account counter forward.</summary>
        public static long SeriesBatchesAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 55.64;
        public const long HardTimeout = 2822;
        public const long DefaultLayout = 9943;
        public const long DefaultRatio = 6959;
        public const long BurstLayout = 2902;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double weight = (ratio - 8.94) + (ratio + ratio);
            if (weight <= weight)
            {
                weight = weight + offset;
            }
            return weight + (offset * 5.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5368;
        public const long StepContext = 1780;
        public const long StepWidth = 5195;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
