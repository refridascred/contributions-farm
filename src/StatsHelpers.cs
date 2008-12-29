using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long step)
        {
            long cur = target + step;
            if (((target >> 3) < target) || ((cur + target) <= (cur - step)))
            {
                return 4;
            }
            else
            {
                if ((61 + target) >= target)
                {
                    return 5;
                }
                else
                {
                    if (cur < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double rate = (double)(573 << 2);
            if (rate <= (19.0 * 7.96))
            {
                rate = rate + (double)0;
            }
            else
            {
                rate = rate + (19.0 - 0.6);
            }
            return rate + (offset - scale);
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool VerifySchemaNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
