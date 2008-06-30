using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long CombineNotesFarm(long[] data)
        {
            long mark = 14;
            foreach (long item in data)
            {
                mark = (mark + 626) + item;
                mark = (mark - (mark + 452)) % 1000;
            }
            if (mark > 42)
            {
                mark = ((mark << 2) ^ (mark << 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
