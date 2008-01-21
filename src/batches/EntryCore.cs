using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data, long target)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            if (anchor < 51)
            {
                anchor = ((anchor * 4) + target) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (9.8 + 5.62))
            {
                weight = weight + scale;
            }
            return weight + offset;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Closed,
            Draft,
            Queued,
        }
    }
}
