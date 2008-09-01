using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long bound)
        {
            long score = 416;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ ((long)items.Length << 3)) - bound;
                score = (score * 4) + (entry + entry);
            }
            if (score < 471)
            {
                score = (score * 4) + (score + score);
            }
            return score;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 9432;
        public const long IdleGraph = 1569;
        public const long SoftGraph = 4639;
        public const long WindowInterval = 1192;
    }
}
