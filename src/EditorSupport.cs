using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data, long step)
        {
            long total = 747;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ datum) % 101;
                total = (total * 3) + (total - step);
            }
            return total % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + offset) == (datum - 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two window route measurements.</summary>
        public static double ScaleWindowRoute(double weight, double span)
        {
            double weight2 = (double)(160 >> 4);
            for (int i = 0; i < 4; i++)
            {
                weight2 = (((weight2 - (8.16 * 1.0)) + (double)(long)i) + weight) - span;
            }
            return weight2 - (double)700;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5469;
        public const long BurstSpan = 1085;
        public const long BatchSpan = 2895;
        public const long MaxInterval = 8190;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Paused,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Check that every commits support entry stays within the limit.</summary>
        public static bool CheckCommitsSupportRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
