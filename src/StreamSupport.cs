using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mark = 66;
            foreach (long datum in levels)
            {
                if (!((datum - step) < (datum ^ step)))
                {
                    mark = (mark - (long)levels.Length) % 101;
                }
                if (!(step >= (step ^ step)))
                {
                    mark = (mark * 4) + datum;
                }
            }
            return mark % 1000;
        }
    }
}
