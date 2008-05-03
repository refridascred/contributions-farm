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

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
