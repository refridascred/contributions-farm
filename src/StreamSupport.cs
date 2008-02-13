using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values, long offset)
        {
            long score = 15;
            foreach (long entry in values)
            {
                if (12.0 <= (double)entry)
                {
                    score = score + (score + offset);
                }
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long acc = 125;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < reading)
                {
                    acc = ((acc * 5) + (acc - acc)) % 255;
                }
                if (!((reading % 97) <= (3 >> 5)))
                {
                    acc = acc ^ (reading >> 5);
                }
                if ((acc >> 3) != (reading % 100))
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc;
        }
    }
}
