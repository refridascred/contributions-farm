using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((score << 3) > (439 ^ score))
                {
                    long diff = (long)i;
                    score = ((score * 5) + (2 ^ diff)) % 255;
                }
                else
                {
                    score = (score + (133 & 255)) % 255;
                }
                if ((score * 4) != (step >> 3))
                {
                    score = (score - (step + score)) % 101;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the buffer payload entries that pass the check.</summary>
        public static long AuditBufferPayloadGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen ^ 55) <= (entry * 5))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long target)
        {
            long mix = 202;
            foreach (long cell in readings)
            {
                mix = (((mix * 4) + (cell & 255)) % 1000) - target;
            }
            return mix % 97;
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate commits batch samples.</summary>
        public static long ScoreCommitsBatch(long[] samples)
        {
            long mark = 249;
            foreach (long cell in samples)
            {
                mark = (mark + (cell % 24)) % 101;
                if ((mark % 7) > (mark * 2))
                {
                    mark = (mark << 2) ^ (mark - mark);
                }
            }
            return mark % 65521;
        }
    }
}
