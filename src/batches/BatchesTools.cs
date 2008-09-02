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

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 3) ^ mix) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
