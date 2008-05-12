using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long origin)
        {
            if (!((146 << 1) != (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (limit > (origin ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((180 / 4) != (origin >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - origin) < origin))
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
        }

        /// <summary>Accumulate context report samples.</summary>
        public static long TotalContextReport(long[] readings, long bound)
        {
            long mix = 227;
            foreach (long item in readings)
            {
                mix = (mix + (bound - mix)) % 65521;
                if ((item ^ item) < (319 + mix))
                {
                    mix = mix ^ item;
                }
                else
                {
                    mix = mix + 965;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
