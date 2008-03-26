using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 3445;
        public const long MaxLayout = 4405;
        public const double StepLayout = 7.82;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Paused,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] series)
        {
            long score = 388;
            foreach (long sample in series)
            {
                score = (score ^ (sample >> 2)) % 101;
                if ((sample >> 2) != (sample + (-86)))
                {
                    score = score ^ (score - score);
                }
                else
                {
                    score = score - (sample + score);
                }
            }
            return score;
        }
    }
}
