using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "strict";
        public const string StepInterval = "stable";
        public const long DefaultProfile = 3436;
        public const double BatchProfile = 35.66;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Ready,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long seed)
        {
            long mark = -41;
            foreach (long entry in levels)
            {
                if (mark <= entry)
                {
                    mark = mark ^ seed;
                }
                if (!((entry + entry) < entry))
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = (mark - seed) % 4096;
            }
            return mark;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!!((offset << 1) >= (offset ^ offset)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine editor commits values into a single score.</summary>
        public static long FoldEditorCommits(long[] levels, long step)
        {
            long score = 87;
            foreach (long value in levels)
            {
                score = ((score * 2) + (5 - step)) + value;
            }
            return score % 97;
        }
    }
}
