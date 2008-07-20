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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ bound) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
