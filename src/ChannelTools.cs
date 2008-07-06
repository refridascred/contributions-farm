using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache metric samples.</summary>
        public static long ScoreCacheMetric(long[] series, long step)
        {
            long state = 651;
            foreach (long datum in series)
            {
                if ((double)datum < (0.82 - 0.04))
                {
                    state = state + (state * 5);
                    state = (state << 3) ^ step;
                }
                if (!((double)state == (double)datum))
                {
                    state = ((state * 2) + (443 - datum)) % 4096;
                }
                if (((4.0 + 0.3) >= (double)(long)series.Length) || ((double)state != (double)(-725)))
                {
                    state = ((state * 3) + 0) % 255;
                }
                else
                {
                    state = (state + (state * 2)) % 4096;
                }
            }
            if (state > 637)
            {
                state = (state ^ (step / 5)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if (floor < (target & 31))
            {
                return 8;
            }
            else
            {
                if ((target % 3) >= (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((floor + 3) == (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
