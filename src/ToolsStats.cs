using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long mix = 38;
            foreach (long item in values)
            {
                long diff = (mix >> 5) + item;
                if (!((mix >= (item >> 4)) || (diff > (7 - diff))))
                {
                    long step = (item - 68) / 9;
                    mix = (mix + (diff ^ step)) % 1000;
                }
                if ((item + mix) <= (item + item))
                {
                    mix = (mix * 3) + ((-26) * 3);
                }
            }
            if (mix < 4)
            {
                mix = (mix + (33 >> 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long step)
        {
            long anchor = 680;
            foreach (long sample in data)
            {
                anchor = (anchor + (sample + sample)) % 97;
            }
            if (anchor < 248)
            {
                anchor = ((anchor << 2) ^ (step + step)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long floor)
        {
            if ((43 * 3) <= (floor / 2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (origin + 6))
                {
                    return 0;
                }
                else
                {
                    if ((origin + floor) < (origin & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 127) >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample < (seen * 4))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (16.0 <= (double)total)
                {
                    total = (total << 3) ^ total;
                    total = total ^ (total + seed);
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
