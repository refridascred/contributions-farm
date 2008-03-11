using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command profile readings against a rule.</summary>
        public static long CountCommandProfileGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)offset < (9.8 + 1.0))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Rank metric support input into a small class.</summary>
        public static long ClassifyMetricSupport(long step, long bound)
        {
            long bound2 = step + bound;
            if ((bound - bound2) != (bound2 * 2))
            {
                return 6;
            }
            else
            {
                if (((bound ^ step) <= (step << 1)) && ((bound << 2) >= (bound + 407)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8032;
        public const long BatchEntry = 6531;
        public const string DefaultInterval = "primary";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if (anchor <= (4 + anchor))
                {
                    anchor = (anchor + 82) % 4096;
                }
                else
                {
                    anchor = (anchor * 4) + (long)i;
                    anchor = anchor - (694 << 1);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long RankSupportRecord(long target, long offset)
        {
            if ((10.0 / 4.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target ^ offset) > (offset / 3))
                {
                    return 7;
                }
                else
                {
                    if ((target % 7) >= (offset + (-54)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + offset) != (target * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
