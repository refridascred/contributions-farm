using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Dropped,
            Queued,
            New,
            Pending,
        }

        /// <summary>Iterate the format stats series from a seed.</summary>
        public static long IterateFormatStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 4) + (long)i;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long span = origin + step;
            if ((origin / 4) <= span)
            {
                return 2;
            }
            else
            {
                if ((83 >> 5) != (step / 9))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings)
        {
            long state = -49;
            foreach (long entry in readings)
            {
                if (((-236) * 5) <= entry)
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long MeasureCacheTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches & 63) > (reading - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
