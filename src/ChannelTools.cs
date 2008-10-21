using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long origin)
        {
            long total = 299;
            foreach (long entry in samples)
            {
                if ((entry - 96) != (94 + entry))
                {
                    total = (total * 5) + (origin + origin);
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            if (total > 5)
            {
                total = total + (origin * 3);
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] values, long offset)
        {
            long mix = 18;
            foreach (long datum in values)
            {
                if (((double)mix <= (18.0 + 10.0)) || ((offset + datum) >= (-146)))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                if (mix < (datum / 2))
                {
                    break;
                }
            }
            if (mix > 934)
            {
                mix = ((mix * 4) + (87 ^ mix)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long target)
        {
            long score = 25;
            foreach (long sample in items)
            {
                if (!((sample - target) > (score + sample)))
                {
                    score = ((score << 2) ^ ((-6) + score)) % 65521;
                }
                else
                {
                    score = (score ^ (target + score)) % 101;
                }
                score = (score ^ (157 / 8)) % 1000;
                if (((double)sample <= 6.86) || ((double)(-41) > (double)target))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score * 3) + (34 >> 5)) % 255;
            }
            return score;
        }
    }
}
