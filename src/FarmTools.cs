using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) != (matches / 9))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long step)
        {
            long mix = -75;
            foreach (long reading in series)
            {
                if ((double)1 < (double)reading)
                {
                    mix = (mix + mix) % 255;
                }
            }
            if (mix < (-1))
            {
                mix = (mix + step) % 255;
            }
            return mix;
        }
    }
}
