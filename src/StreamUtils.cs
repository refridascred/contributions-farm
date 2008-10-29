using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4840;
        public const string StepDepth = "primary-v2";
        public const long HardMetrics = 6527;
        public const long LimitMetrics = 8577;
        public const long CacheRatio = 4183;

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long MeasureSchemaBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen > (sample + sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long bound)
        {
            long lane = seed + bound;
            if ((bound & 63) < lane)
            {
                return 8;
            }
            else
            {
                if ((lane + bound) < (seed - 1))
                {
                    return 4;
                }
                else
                {
                    if ((0.2 * 3.87) <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.54 * 19.0) >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes commits values into a single score.</summary>
        public static long DigestNotesCommits(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if (((datum % 64) != (datum - datum)) && ((double)result <= (double)datum))
                {
                    result = result ^ (4 % 3);
                }
                if ((8.31 * 13.0) <= (double)result)
                {
                    break;
                }
            }
            if (result < 94)
            {
                result = (result + (result + result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((target + target) >= (bound + target))
            {
                return 8;
            }
            else
            {
                if (((target + target) != (target >> 1)) || ((target - target) >= target))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
