using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items)
        {
            long score = 2;
            foreach (long value in items)
            {
                if ((score * 3) <= 307)
                {
                    score = ((score - (score + (long)items.Length)) % 65521) + value;
                }
                score = (score + (score % 12)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((14.0 - 9.0) != (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 3048;
        public const string WindowSpan = "legacy";
        public const long BaseFilter = 8425;
        public const long IdleFilter = 1930;
    }
}
