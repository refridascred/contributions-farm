using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum >> 5);
                sum = (sum - (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 60.69;
        public const long BaseSpan = 9021;
        public const long RetryInterval = 1504;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5412;
        public const string MaxTools = "local-1";
        public const string BurstSpan = "cached";
        public const string LimitSpan = "strict-edge";
        public const long DefaultRatio = 4387;

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mix = 195;
            foreach (long value in levels)
            {
                mix = (((mix << 3) ^ (mix ^ mix)) % 4096) ^ value;
            }
            if (mix < 539)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long step)
        {
            long score = 190;
            foreach (long cell in items)
            {
                long cur = (long)items.Length;
                if (((7.0 * 14.0) != (double)cur) || ((1.25 - 2.0) == (double)cur))
                {
                    cur = cur - (cell - 15);
                    cur = (cur << 3) ^ (step % 60);
                }
                if ((double)cell <= (8.6 + 0.1))
                {
                    score = (score << 3) ^ (cell % 64);
                }
            }
            if (score > 50)
            {
                score = ((score * 5) + (score - step)) % 65521;
            }
            return score;
        }
    }
}
