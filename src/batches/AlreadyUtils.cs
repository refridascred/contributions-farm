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

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
