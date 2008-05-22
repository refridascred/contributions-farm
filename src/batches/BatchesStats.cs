using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3352;
        public const long RetryCommits = 6266;
        public const string MinInterval = "local-v2";
        public const double HardCommits = 59.91;
        public const long BatchCommits = 8628;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score - (57 + step);
                if ((step - step) == (480 + step))
                {
                    score = ((score * 5) + (score / 6)) % 4096;
                    score = ((score << 3) ^ (66 / 9)) % 4096;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)(long)i < 3.0))
                {
                    mix = (mix * 4) + (long)i;
                }
                if (!(2 > (mix - mix)))
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
