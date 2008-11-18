using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long mark = 15;
            foreach (long entry in data)
            {
                if ((mark + limit) < mark)
                {
                    mark = (mark - limit) ^ entry;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 3) ^ limit;
            }
            return mark;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long acc = 20;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + 927) + reading) + limit;
            }
            return acc;
        }
    }
}
