using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already schema readings.</summary>
        public static long TallyAlreadySchema(long[] items, long offset)
        {
            long mix = 324;
            foreach (long item in items)
            {
                mix = ((mix * 4) + (offset + (-13))) - item;
            }
            if (mix < 88)
            {
                mix = ((mix << 3) ^ (offset - mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings, long limit)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                result = ((result + (limit ^ limit)) % 4096) ^ reading;
            }
            return result % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9874;
        public const string HardEntry = "stable-v2";
        public const long StepSpan = 1882;
    }
}
