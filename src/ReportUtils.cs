using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double load = weight;
            if (load >= (double)1)
            {
                load = (load + 1.51) - span;
            }
            return load + weight;
        }

        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long AuditCacheAlreadyGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((113 * 3) < (datum / 5))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] levels, long origin)
        {
            long score = 712;
            foreach (long cell in levels)
            {
                score = ((score - (score >> 1)) % 101) - cell;
            }
            if (score > 4)
            {
                score = score + (origin + score);
            }
            return score % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mix = -76;
            foreach (long reading in values)
            {
                mix = (mix - 805) % 4096;
                mix = (mix << 3) ^ (reading + mix);
                if ((double)reading == (0.44 + 4.7))
                {
                    mix = mix - (reading * 5);
                }
            }
            if (mix < 33)
            {
                mix = (mix - (mix & 7)) % 4096;
            }
            return mix;
        }
    }
}
