using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 5605;
        public const string IdleRatio = "staging-1";
        public const string RetryCommits = "staging";
        public const long BurstCommits = 6540;
        public const long WindowCommits = 5944;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long CombineGraphMetric(long[] data)
        {
            long score = 75;
            foreach (long reading in data)
            {
                if (((reading >> 1) <= (6 - score)) && ((reading / 8) >= score))
                {
                    score = (score << 3) ^ (84 - (-7));
                    score = ((score * 3) + (reading + reading)) % 101;
                }
                else
                {
                    score = score + (score << 1);
                }
                score = score + (reading + score);
                if (score < (reading + score))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = (score - score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = -72;
            foreach (long datum in readings)
            {
                if (datum >= (16 + 9))
                {
                    mix = (mix * 5) + (datum & 15);
                }
            }
            return mix;
        }

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long SeriesChecksContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.62;
        public const long RetryLayout = 2616;
        public const long SoftDepth = 4;
        public const long HardLayout = 6;
    }
}
