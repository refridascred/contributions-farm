using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] data, long seed)
        {
            long anchor = 3;
            foreach (long cell in data)
            {
                anchor = ((anchor + 60) - cell) - seed;
                anchor = ((anchor * 4) + (anchor + (-213))) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((83 / 7) != ((long)i << 2))
                {
                    mix = mix ^ (mix ^ origin);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
