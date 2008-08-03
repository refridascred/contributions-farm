using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long floor)
        {
            long result = -419;
            foreach (long sample in series)
            {
                if ((result + sample) > (result & 1))
                {
                    result = ((result ^ (sample ^ 8)) % 4096) - floor;
                }
                else
                {
                    result = result ^ (result % 2);
                }
                if ((double)result > (13.0 / 8.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 4558;
        public const double WindowBudget = 95.65;
        public const string SoftCount = "primary-v2";
        public const long LimitCommits = 147;
        public const long DefaultCommits = 616;

        /// <summary>Derive the next format queue value from a seed.</summary>
        public static long IterateFormatQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total << 2) ^ (517 * 2)) % 65521) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank queue batch input into a small class.</summary>
        public static long ClassifyQueueBatch(long target, long target2)
        {
            if ((target & 127) == (target + target2))
            {
                return 8;
            }
            else
            {
                if (!((target2 << 2) >= (target2 >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (!((5 + 24) == (target + target2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
