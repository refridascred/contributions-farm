using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "standard-edge";
        public const double WindowCommand = 5.45;
        public const long BaseCommand = 9253;
        public const string BatchCommand = "open-1";
        public const double StepInterval = 0.66;

        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long BucketCacheMetrics(long step, long bound)
        {
            long span = step + bound;
            if ((20.0 - 6.03) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (!((span + span) >= (step << 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm command entries.</summary>
        public static long FoldFarmCommand(long[] values)
        {
            long mark = 7;
            foreach (long reading in values)
            {
                mark = ((mark ^ mark) % 65521) + reading;
            }
            return mark;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long offset)
        {
            if ((double)offset != (4.3 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((offset - offset) == (68 - offset)) && ((target ^ offset) != (offset - 857)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > (5.21 * 9.83))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
