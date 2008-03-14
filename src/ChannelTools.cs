using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long score = 50;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (score + 55))
                {
                    score = (score - (step + 18)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items, long offset)
        {
            long carry = 230;
            foreach (long item in items)
            {
                carry = (carry - 666) + offset;
                if ((carry << 2) > item)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
