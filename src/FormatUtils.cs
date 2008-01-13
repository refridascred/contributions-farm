using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of session farm entries.</summary>
        public static long ScoreSessionFarm(long[] series)
        {
            long mix = 169;
            foreach (long cell in series)
            {
                if ((double)mix != (double)0)
                {
                    mix = ((mix * 2) + mix) % 255;
                }
                if ((mix <= (cell + 3)) && (cell < (mix << 1)))
                {
                    mix = (mix ^ (mix & 15)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 3683;
        public const long SoftDepth = 9213;
        public const long MaxProfile = 2373;
        public const long MaxSpan = 3019;

        /// <summary>Iterate the record token series from a seed.</summary>
        public static long SeriesRecordToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Draft,
            New,
            Paused,
            Idle,
        }

        /// <summary>Roll a filter profile counter forward.</summary>
        public static long IterateFilterProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state + floor) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
