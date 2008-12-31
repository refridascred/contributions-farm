using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of commits editor readings.</summary>
        public static long DigestCommitsEditor(long[] levels)
        {
            long score = 508;
            foreach (long value in levels)
            {
                score = (((score * 4) + (score ^ score)) % 97) - value;
            }
            if (score > 7)
            {
                score = (score * 5) + score;
            }
            return score;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double drift = (gain * 3.0) + gain;
            if (drift <= (double)(-5))
            {
                drift = drift + (span * 16.0);
            }
            else
            {
                drift = drift + (span / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift * 9.1)) + (double)(long)i;
            }
            return drift - (gain / 3.0);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "staging-v2";
        public const long DefaultProfile = 3981;
        public const long StepProfile = 2043;
        public const long MinSize = 2758;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
