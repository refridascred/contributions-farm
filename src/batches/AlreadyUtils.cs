using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of token already entries.</summary>
        public static long TotalTokenAlready(long[] readings)
        {
            long mix = -633;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 3) ^ ((-21) ^ (long)i)) % 97;
                }
                if ((double)mix > (2.6 + 0.7))
                {
                    mix = (mix + (mix + mix)) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (9 + cell)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + tally) != (long)levels.Length)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
