using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mix = 54;
            foreach (long entry in data)
            {
                mix = mix ^ entry;
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ result) % 1000;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long seed)
        {
            long anchor = 281;
            foreach (long cell in samples)
            {
                if ((anchor & 63) > ((long)samples.Length + seed))
                {
                    anchor = ((anchor << 2) ^ anchor) - cell;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + (52 / 8)) % 255;
            }
            return anchor % 1000;
        }
    }
}
