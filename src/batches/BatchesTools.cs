using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of format command readings.</summary>
        public static long CombineFormatCommand(long[] data, long step)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((((anchor * 5) + anchor) % 97) - (long)i) + sample;
                }
                anchor = anchor ^ (step * 4);
            }
            if (anchor < 14)
            {
                anchor = (anchor + step) % 255;
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (2 % 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((seed << 1) >= (entry % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
