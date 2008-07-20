using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a farm channel counter forward.</summary>
        public static long SeriesFarmChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step < (step << 2)) || ((step / 9) >= (70 - 0)))
                {
                    anchor = anchor ^ (step - anchor);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
