using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if ((1.07 * 17.0) <= (double)step)
                {
                    acc = ((acc << 2) ^ (long)i) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 3) + 326) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
