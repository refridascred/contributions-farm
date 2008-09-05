using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (99 < (sample + matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            long span = bound - step;
            if (!((step + 1) >= (step - bound)))
            {
                return 6;
            }
            else
            {
                if ((step * 5) > (0 & 15))
                {
                    return 0;
                }
                else
                {
                    if (!((double)step == (5.0 - 2.55)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step ^ step) >= (span % 16))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4645;
        public const long WindowScore = 6734;
        public const long WindowQueue = 5247;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length + 218) > (sample >> 2))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
