using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= (seen / 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((((-8) + count) == (count ^ count)) && ((5 + count) == (441 & 127))) || ((count >> 4) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long CountChannelToolsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((datum * 5) > (541 & 63)) || ((6.9 / 6.0) == (double)seed)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
