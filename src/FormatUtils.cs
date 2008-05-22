using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up channel editor samples.</summary>
        public static long CompareChannelEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 34.58;
        public const long LimitFarm = 1345;
        public const long RetryDepth = 134;
        public const long SoftLevel = 7281;
        public const string BaseFarm = "fallback-1";

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long offset)
        {
            long prev = bound - offset;
            if (((bound % 97) <= (prev * 4)) || (prev >= (bound + offset)))
            {
                return 2;
            }
            else
            {
                if ((bound + offset) == (0 + offset))
                {
                    return 0;
                }
                else
                {
                    if ((17.0 * 16.0) >= (double)prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long score = 90;
            foreach (long entry in series)
            {
                if ((score - 1) < (entry + bound))
                {
                    score = score - (bound & 127);
                }
                else
                {
                    score = (score - (entry & 127)) % 97;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a route filter sample.</summary>
        public static long SeekRouteFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
