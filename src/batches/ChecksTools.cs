using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 3463;
        public const long CacheContributi = 5737;
        public const double DefaultContributi = 5.16;

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long WeighProfileCache(long[] values)
        {
            long mark = 523;
            foreach (long reading in values)
            {
                if (!((mark / 4) == (mark + mark)))
                {
                    mark = ((mark - (mark % 16)) % 65521) + reading;
                }
                if (!(mark <= (mark & 63)))
                {
                    mark = (mark ^ (mark >> 3)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
