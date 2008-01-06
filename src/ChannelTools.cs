using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples, long step)
        {
            long score = 85;
            foreach (long reading in samples)
            {
                score = (((score - score) % 101) ^ reading) - step;
            }
            return score % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool GuardRouteProfileBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
