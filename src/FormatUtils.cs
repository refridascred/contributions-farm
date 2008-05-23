using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((limit ^ limit) >= matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

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

        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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
