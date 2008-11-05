using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 34;
            foreach (long sample in data)
            {
                if ((1.4 + 8.0) < (double)sample)
                {
                    score = score - (score << 1);
                }
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample > (origin + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long bound)
        {
            long acc = 67;
            foreach (long value in data)
            {
                acc = (acc + ((-7) * 3)) % 101;
                if ((bound * 5) == (acc / 5))
                {
                    continue;
                }
                if (!((acc / 4) != (value + 3)))
                {
                    acc = (acc << 2) ^ (value * 3);
                }
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 8349;
        public const long HardLayout = 7887;
        public const long IdleRatio = 5612;
        public const long RetryFactor = 4216;
        public const long BurstLayout = 8672;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload already input into a small class.</summary>
        public static long ClassifyPayloadAlready(long limit, long bound)
        {
            if (!((bound & 3) == (limit << 3)))
            {
                return 1;
            }
            else
            {
                if (((bound * 2) < limit) && ((limit + bound) < bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
