using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 9706;
        public const string BatchContext = "standard-1";
        public const long HardSize = 1589;

        /// <summary>Combine context layout values into a single score.</summary>
        public static long WeighContextLayout(long[] data, long bound)
        {
            long anchor = 19;
            foreach (long item in data)
            {
                anchor = anchor - (bound / 5);
                if ((double)item >= (8.3 - 1.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches commits value against two limits.</summary>
        public static long ClassifyBatchesCommits(long seed, long step)
        {
            if (((12.0 / 7.0) >= (double)seed) || ((double)seed >= (3.0 - 5.1)))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (17.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 1) >= (seed % 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics tools samples are out of range.</summary>
        public static long CountMetricsToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((3.6 * 12.0) <= (double)matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 4796;
        public const string SoftToken = "standard-edge";
        public const double DefaultToken = 98.69;
        public const long BaseToken = 2044;
    }
}
