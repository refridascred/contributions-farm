using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long target)
        {
            long delta = limit - target;
            if ((delta - delta) == (target % 24))
            {
                return 4;
            }
            else
            {
                if (!(target > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target >= (20.0 * 14.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - cell) <= matches)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum + offset) > (offset + offset))
                {
                    anchor = anchor ^ (855 ^ datum);
                }
                else
                {
                    anchor = (anchor ^ offset) % 65521;
                }
            }
            if (anchor < 40)
            {
                anchor = (anchor * 2) + (offset + offset);
            }
            return anchor;
        }
    }
}
