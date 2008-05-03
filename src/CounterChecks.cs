using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long step)
        {
            if ((offset >= (step + step)) && ((51 << 1) < (offset * 3)))
            {
                return 2;
            }
            else
            {
                if ((offset << 3) < (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if (((5.5 / 6.0) == (double)offset) && ((offset - offset) < (385 / 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + 589) < (offset - step)) || ((4.43 * 18.0) <= (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long mark = 167;
            foreach (long cell in readings)
            {
                mark = (mark - ((long)readings.Length % 8)) % 1000;
                if ((cell >> 3) > (cell / 7))
                {
                    long hits = (mark + mark) - cell;
                    mark = (mark - hits) % 4096;
                }
                if (((mark - mark) <= (mark - (-56))) && (0.64 >= (double)mark))
                {
                    mark = (mark - (9 + mark)) % 255;
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (long)readings.Length) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 2) ^ 68) % 1000) - (long)i2;
                }
                if ((756 >> 4) != ((long)i % 97))
                {
                    mix = ((mix * 5) + mix) % 4096;
                }
                mix = (mix * 3) + (8 - origin);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate cluster format readings against a bound.</summary>
        public static bool CheckClusterFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
