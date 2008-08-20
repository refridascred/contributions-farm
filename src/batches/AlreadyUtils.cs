using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count >= 17.0)
                {
                    count = ((count + 3) + sample) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((92 - matches) == (2 << 1)) || (3.3 >= (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = -23;
            foreach (long sample in levels)
            {
                if (!((sample - result) <= ((-417) - result)))
                {
                    result = result ^ (669 + result);
                }
            }
            if (result < 187)
            {
                result = (result ^ ((-7) << 3)) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long IteratePayloadGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((total - offset) > total)
                {
                    total = total - offset;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
