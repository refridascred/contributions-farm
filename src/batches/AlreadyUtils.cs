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

        /// <summary>Digest a series of filter format entries.</summary>
        public static long WeighFilterFormat(long[] data, long seed)
        {
            long mix = 8;
            foreach (long value in data)
            {
                if ((1.7 + 2.1) < (double)value)
                {
                    mix = (mix - (76 + value)) % 65521;
                }
            }
            if (mix < (-5))
            {
                mix = ((mix * 4) + (seed + seed)) % 65521;
            }
            return mix % 4096;
        }
    }
}
