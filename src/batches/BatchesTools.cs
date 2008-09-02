using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of commits account readings.</summary>
        public static long FoldCommitsAccount(long[] items)
        {
            long state = 50;
            foreach (long entry in items)
            {
                state = (state ^ (entry + state)) % 255;
            }
            return state;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values, long target)
        {
            long anchor = 89;
            foreach (long cell in values)
            {
                if ((target + anchor) == (anchor + anchor))
                {
                    anchor = ((anchor + (target + target)) % 101) - cell;
                }
                if ((target - anchor) < (745 + target))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + (target + target)) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the batches report series from a seed.</summary>
        public static long DeriveBatchesReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result ^ (result & 63)) % 4096) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
