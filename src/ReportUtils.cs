using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank checks order input into a small class.</summary>
        public static long SortChecksOrder(long target, long step)
        {
            long step2 = target - step;
            if ((target >> 5) > (target - step2))
            {
                return 6;
            }
            else
            {
                if (14.0 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((step + target) >= (step2 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor + matches) > datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long bound)
        {
            long sum = 58;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ value) % 65521) + bound;
            }
            return sum % 97;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
