using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double rate2 = (double)(7 ^ (-7));
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (double)(long)i) - rate;
            }
            return rate2 + offset;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long origin)
        {
            long state = 550;
            foreach (long reading in series)
            {
                if (origin > reading)
                {
                    state = (state * 2) + reading;
                }
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((3.65 - 6.5) >= (double)seen) || ((double)16 != (double)cell))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result << 3) ^ (result >> 4);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
