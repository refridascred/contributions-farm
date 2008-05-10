using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi token entries.</summary>
        public static long ScoreContributiToken(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix - (value - value)) % 65521;
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long seed)
        {
            long score = 598;
            foreach (long value in data)
            {
                if ((double)84 == (double)score)
                {
                    score = ((score - score) % 4096) - value;
                }
                if ((seed + score) <= ((long)data.Length & 3))
                {
                    break;
                }
            }
            if (score < 9)
            {
                score = (score ^ seed) % 101;
            }
            return score;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Done,
            Failed,
            Draft,
            Active,
        }
    }
}
