using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a filter counter value against two limits.</summary>
        public static long BucketFilterCounter(long bound, long origin)
        {
            if ((0.04 * 14.0) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((origin + origin) > bound)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mix = 15;
            foreach (long cell in values)
            {
                if (!((6.6 / 5.0) == (double)mix))
                {
                    mix = ((mix << 2) ^ (cell - mix)) % 1000;
                }
                if (((mix - 941) > (mix ^ mix)) || ((899 + 309) <= ((long)values.Length - mix)))
                {
                    mix = (mix - (cell + mix)) % 1000;
                }
            }
            return mix;
        }
    }
}
