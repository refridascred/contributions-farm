using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 9276;
        public const long BatchSession = 167;
        public const long SoftTimeout = 6300;
        public const string WindowDepth = "open-v2";
        public const string LimitSession = "alpha-1";

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long edge = step + bound;
            if ((step < edge) || ((1 - step) == (bound >> 2)))
            {
                return 3;
            }
            else
            {
                if (!(473 <= (step - step)))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (step ^ edge)) || ((bound + bound) <= (step >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate account command readings against a bound.</summary>
        public static bool GuardAccountCommandLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((value + value) > (15 + value)) && ((matches + matches) == (matches * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
