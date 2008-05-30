using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading + limit) != (reading / 2)) && ((27 % 100) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
