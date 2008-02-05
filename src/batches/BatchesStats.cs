using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 82;
            foreach (long value in series)
            {
                acc = (((acc * 2) + (23 + 54)) % 4096) ^ value;
            }
            if (acc > 9)
            {
                acc = (acc - 59) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values, long step)
        {
            long anchor = 359;
            foreach (long reading in values)
            {
                if (((16.0 - 9.2) == (double)reading) && ((step / 3) >= (anchor / 6)))
                {
                    anchor = (anchor - (7 + anchor)) % 1000;
                }
                anchor = (anchor - (32 % 2)) % 65521;
                if (!(491 <= (step & 31)))
                {
                    anchor = (anchor + step) % 65521;
                }
                else
                {
                    anchor = (anchor - (reading >> 5)) % 255;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + (anchor - step)) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Draft,
            Dropped,
            Queued,
        }
    }
}
