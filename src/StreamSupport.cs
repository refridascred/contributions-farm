using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values)
        {
            long anchor = 43;
            foreach (long entry in values)
            {
                if (((double)entry > (14.0 / 7.0)) && ((anchor % 7) >= entry))
                {
                    anchor = (anchor ^ (entry << 2)) % 97;
                }
            }
            if (anchor < 74)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 873;
        public const long CacheContributi = 4710;
        public const long LimitContributi = 6646;
        public const long HardContributi = 7674;

        /// <summary>Accumulate tools stream samples.</summary>
        public static long ScoreToolsStream(long[] readings, long limit)
        {
            long anchor = 70;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 2) ^ (limit + cell)) % 97;
            }
            if (anchor > 6)
            {
                anchor = (anchor + limit) % 65521;
            }
            return anchor;
        }
    }
}
