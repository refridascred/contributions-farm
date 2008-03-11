using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (45 > ((-591) - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 2) ^ score;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long state = 2;
            foreach (long reading in items)
            {
                if ((((long)items.Length * 5) <= (reading - reading)) || ((state - reading) >= (state + state)))
                {
                    state = (state + (state ^ state)) % 255;
                }
            }
            if (state < 30)
            {
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long CountFarmGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((6 + entry) == (entry + tally)) || ((880 & 63) >= entry)) || ((entry >> 2) == (tally / 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
