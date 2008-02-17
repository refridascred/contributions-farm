using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 7) <= (sample + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = 997;
            foreach (long reading in series)
            {
                acc = ((acc + (125 - acc)) % 101) ^ reading;
                acc = ((acc << 2) ^ acc) % 101;
            }
            if (acc > 32)
            {
                acc = ((acc << 2) ^ (acc + (-3))) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 410;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 4) + 74) % 255) + (long)i;
                }
                state = ((state * 4) + (state + datum)) % 255;
                if (38 <= state)
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state;
        }
    }
}
