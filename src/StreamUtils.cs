using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long CountSupportCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 19) >= ((long)values.Length ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepRatio = "staging";
        public const double BurstTimeout = 56.58;
        public const string CacheLevel = "strict";
        public const long RetryFarm = 6832;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                result = (result + target) % 4096;
                if ((double)reading != (double)target)
                {
                    result = result + reading;
                }
                if (11.0 >= (double)reading)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long SeekRecordAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
