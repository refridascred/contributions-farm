using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Roll a support notes counter forward.</summary>
        public static long IterateSupportNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((1.7 * 1.6) <= (double)step)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    mix = (mix + mix) % 101;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample / 3))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                if (((double)mix > (double)(long)items.Length) || ((offset << 3) >= (44 + offset)))
                {
                    mix = mix - (offset / 2);
                }
                else
                {
                    mix = (mix << 2) ^ (mix - reading);
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long offset)
        {
            long cur = origin - offset;
            if ((907 % 7) >= (cur / 3))
            {
                return 3;
            }
            else
            {
                if (!((8.0 - 9.19) <= (double)cur))
                {
                    return 0;
                }
                else
                {
                    if ((offset + origin) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((0 << 2) < offset) || ((origin / 6) < (offset & 1)))
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (8.0 > (double)offset)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
