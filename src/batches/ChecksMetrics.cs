using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the already batch series from a seed.</summary>
        public static long IterateAlreadyBatch(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!(((1 ^ offset) >= anchor) && (((long)i + 8) < anchor)))
                {
                    anchor = (anchor + anchor) % 255;
                }
                if ((offset >= ((long)i + 511)) || (((-46) + offset) <= (anchor - offset)))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seed << 1) <= ((long)readings.Length + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long bound2)
        {
            if ((bound + bound) <= (66 + bound2))
            {
                return 8;
            }
            else
            {
                if ((bound >> 4) <= (bound2 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 * 5) > 4)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound2 - bound) == (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
