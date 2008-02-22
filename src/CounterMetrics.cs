using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long seed)
        {
            if (((step * 3) != (step + 7)) || (121 <= seed))
            {
                return 7;
            }
            else
            {
                if ((seed >> 1) > 0)
                {
                    return 3;
                }
                else
                {
                    if (seed > step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long offset)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = (((mark << 2) ^ (mark & 255)) ^ entry) + offset;
            }
            return mark % 97;
        }
    }
}
