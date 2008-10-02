using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long target2)
        {
            if ((target / 9) > (target2 + target))
            {
                return 0;
            }
            else
            {
                if (target2 >= (target2 >> 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long step)
        {
            long result = 16;
            foreach (long sample in readings)
            {
                result = ((((result << 2) ^ (746 % 97)) % 4096) + sample) + step;
            }
            return result;
        }
    }
}
