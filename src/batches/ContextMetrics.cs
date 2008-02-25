using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Stale,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((slot * 3) < (slot - seed))
            {
                return 0;
            }
            else
            {
                if ((9.0 * 7.5) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a graph payload reading by value.</summary>
        public static long LocateGraphPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks channel samples.</summary>
        public static long PairChecksChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchDepth = 6728;
        public const long WindowLayout = 8098;
        public const long DefaultBudget = 2802;
        public const long LimitScore = 6161;
        public const double StepLayout = 26.18;
    }
}
