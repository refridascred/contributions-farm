using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            long bound2 = bound + origin;
            if (bound > ((-775) ^ bound2))
            {
                return 3;
            }
            else
            {
                if (((double)bound2 < (3.4 / 8.0)) && ((bound2 + origin) >= (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (bound + bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long WeighChannelChecks(long[] items, long step)
        {
            long mix = 568;
            foreach (long reading in items)
            {
                if ((20 + mix) != (step - (long)items.Length))
                {
                    mix = (mix - (step & 7)) + reading;
                }
                else
                {
                    mix = (mix ^ ((long)items.Length + step)) % 65521;
                }
            }
            if (mix < 884)
            {
                mix = (mix - (step - step)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 2416;
        public const long WindowNotes = 1321;
        public const long CacheNotes = 2361;
        public const long BatchSpan = 3892;
    }
}
