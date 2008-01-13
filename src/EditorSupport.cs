using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((target << 3) <= (long)data.Length)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
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

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5669;
        public const double MinQueue = 49.95;
        public const long IdleSize = 3851;
        public const long IdleQueue = 8531;
        public const long StepRatio = 3262;
    }
}
