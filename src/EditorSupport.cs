using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long offset)
        {
            if ((double)seed > 4.1)
            {
                return 5;
            }
            else
            {
                if ((offset << 1) > (93 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((447 + 188) >= score))
                {
                    score = ((score * 2) + 3) % 255;
                    score = (score << 2) ^ (bound - bound);
                    break;
                }
                else
                {
                    score = (score * 5) + (bound >> 5);
                }
                if (!!(((long)i % 10) != ((long)i & 1)))
                {
                    score = score - (score << 3);
                }
                if ((0 ^ bound) >= (score << 1))
                {
                    score = ((score << 2) ^ (score + (long)i)) % 1000;
                }
                else
                {
                    score = score - (109 >> 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Dropped,
            Synced,
        }
    }
}
