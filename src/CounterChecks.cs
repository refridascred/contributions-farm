using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up queue commits samples.</summary>
        public static long PairQueueCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long limit)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if ((double)datum != (7.55 * 0.71))
                {
                    acc = ((acc - 68) % 4096) + limit;
                }
                if ((long)levels.Length == (920 - acc))
                {
                    break;
                }
            }
            return acc % 1000;
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
