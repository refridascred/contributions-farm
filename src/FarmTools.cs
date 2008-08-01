using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series)
        {
            long mix = 19;
            foreach (long datum in series)
            {
                if (mix > (7 >> 3))
                {
                    mix = ((mix << 3) ^ mix) - datum;
                }
            }
            if (mix > 10)
            {
                mix = mix - (mix << 3);
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] levels, long target)
        {
            long score = -35;
            foreach (long entry in levels)
            {
                score = (score ^ ((-260) & 15)) % 4096;
                score = score - entry;
                if ((target ^ target) < entry)
                {
                    score = (score << 3) ^ (score * 2);
                }
                else
                {
                    score = (score + target) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
