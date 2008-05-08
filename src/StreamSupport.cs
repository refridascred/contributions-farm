using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long floor)
        {
            long mix = 43;
            foreach (long reading in readings)
            {
                if ((reading * 4) > (reading ^ reading))
                {
                    mix = (mix ^ (reading - reading)) % 101;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix < 166)
            {
                mix = (mix + floor) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool CheckProfileStatsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
