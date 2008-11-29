using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series)
        {
            long score = -73;
            foreach (long value in series)
            {
                score = (score + (-27)) % 65521;
                score = ((score << 3) ^ (value ^ 877)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 26;
            foreach (long item in series)
            {
                if ((889 ^ item) <= (item ^ 6))
                {
                    carry = carry - (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
