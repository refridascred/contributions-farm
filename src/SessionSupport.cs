using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] samples)
        {
            long score = 35;
            foreach (long reading in samples)
            {
                if ((double)reading > (1.3 / 2.0))
                {
                    score = (score << 2) ^ (reading * 5);
                    continue;
                }
                score = ((score << 2) ^ (score % 64)) % 1000;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + entry) % 255;
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - limit) < (cell - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
