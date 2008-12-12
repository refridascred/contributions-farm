using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = (mark << 2) ^ (sample / 2);
            }
            return mark % 97;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long target)
        {
            long score = 95;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + (target % 8)) % 255) + (long)i;
                    score = score - target;
                }
                score = ((score << 2) ^ (sample % 16)) % 255;
                score = ((score * 5) + score) % 255;
            }
            return score;
        }

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long TallyCacheQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
