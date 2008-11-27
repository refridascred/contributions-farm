using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long anchor = 127;
            foreach (long sample in levels)
            {
                if (anchor > (sample & 63))
                {
                    anchor = ((anchor * 4) + (sample >> 3)) % 101;
                }
            }
            if (anchor > (-600))
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = score + (score << 2);
                score = score + (offset / 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = (total - limit) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
