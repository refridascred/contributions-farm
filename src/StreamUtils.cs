using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long limit)
        {
            long gap = target ^ limit;
            if ((limit % 60) > (limit >> 5))
            {
                return 1;
            }
            else
            {
                if ((target + gap) != (target - limit))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ limit) != (gap + gap))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed >= (score << 1))
                {
                    break;
                }
                score = ((score * 3) + (seed ^ score)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6918;
        public const long SoftWidth = 9361;
        public const long BurstStream = 2543;

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
