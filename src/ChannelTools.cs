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

        /// <summary>Accumulate stream graph samples.</summary>
        public static long TallyStreamGraph(long[] series)
        {
            long state = 64;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state ^ reading) % 1000) ^ (long)i;
                }
                if ((state << 3) > 5)
                {
                    state = (state + (state + state)) % 97;
                }
            }
            return state;
        }
    }
}
