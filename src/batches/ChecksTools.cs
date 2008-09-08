using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - 135;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Retry,
            Pending,
            Paused,
            New,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long origin)
        {
            long mix = 88;
            foreach (long value in readings)
            {
                mix = mix - mix;
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix << 2) ^ value) % 255) ^ (long)i;
                }
                if (!((value << 1) <= (value + origin)))
                {
                    mix = ((mix * 5) + (value * 4)) % 1000;
                }
                else
                {
                    mix = (mix + (origin << 3)) % 97;
                }
            }
            if (mix > 57)
            {
                mix = (mix << 2) ^ 55;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long step)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (score << 2))
                {
                    score = ((score * 5) + (step + step)) % 1000;
                }
                else
                {
                    score = (score ^ sample) % 101;
                }
            }
            return score;
        }
    }
}
