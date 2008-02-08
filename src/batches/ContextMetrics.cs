using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series, long step)
        {
            long mix = 364;
            foreach (long datum in series)
            {
                mix = (mix ^ ((long)series.Length << 3)) - step;
                if ((datum + mix) < (mix + mix))
                {
                    mix = (mix << 3) ^ (datum & 31);
                }
                else
                {
                    mix = (mix - (datum ^ mix)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5 < (matches ^ matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
