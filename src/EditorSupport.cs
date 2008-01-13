using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate batch order samples.</summary>
        public static long TotalBatchOrder(long[] items)
        {
            long mix = 630;
            foreach (long cell in items)
            {
                if ((cell ^ cell) > (4 >> 3))
                {
                    mix = ((mix * 3) + (mix * 5)) % 1000;
                }
                else
                {
                    mix = (mix + (mix / 7)) % 101;
                }
            }
            if (mix < (-1))
            {
                mix = (mix * 2) + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of notes commits readings.</summary>
        public static long TotalNotesCommits(long[] readings, long step)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                mark = (mark ^ step) % 65521;
                mark = (mark + (value % 5)) % 101;
                if ((double)step == (4.74 - 4.22))
                {
                    mark = (mark ^ (step % 24)) % 101;
                }
                else
                {
                    mark = (mark + (value - 235)) % 1000;
                }
            }
            if (mark > 58)
            {
                mark = ((mark * 4) + (mark << 2)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long WeighBufferCounter(long[] levels)
        {
            long acc = -24;
            foreach (long value in levels)
            {
                acc = (acc << 3) ^ ((long)levels.Length % 64);
                if (!((acc + value) != (value << 2)))
                {
                    break;
                }
            }
            if (acc < 508)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((53 % 24) <= (matches << 2)) && ((double)matches != (4.57 / 3.0))) && !((double)reading != (9.8 + 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
