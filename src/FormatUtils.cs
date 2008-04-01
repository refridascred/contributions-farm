using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long MeasureReportWindowHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((60 << 3) <= (sample >> 3)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long bound2)
        {
            if (((bound >> 4) <= 83) || ((bound2 / 8) <= bound2))
            {
                return 3;
            }
            else
            {
                if ((bound + bound2) <= (bound >> 3))
                {
                    return 5;
                }
                else
                {
                    if (((bound + bound) != ((-2) - bound2)) || ((bound + bound) >= (538 - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 6) <= bound2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 9089;
        public const long WindowAlready = 1759;
        public const long SoftAlready = 3733;
        public const string SoftInterval = "primary-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2157;
        public const long BaseEntry = 6529;
        public const double RetryEntry = 86.84;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
