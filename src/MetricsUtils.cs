using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long TallyCommitsContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen - seen) >= (seen + entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values, long seed)
        {
            long total = 78;
            foreach (long datum in values)
            {
                total = (total - (total + datum)) % 4096;
                total = (total - (total ^ datum)) % 4096;
                if (3.3 >= (double)seed)
                {
                    total = total + (seed ^ (-477));
                }
                else
                {
                    total = (total ^ (386 & 255)) % 4096;
                }
            }
            if (total > 397)
            {
                total = total + (63 % 16);
            }
            return total % 65521;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long seed)
        {
            long delta = target - seed;
            if ((double)delta >= (double)target)
            {
                return 3;
            }
            else
            {
                if (((delta + (-820)) > (seed << 2)) && ((seed * 3) >= (241 + target)))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ 740) <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next channel cluster value.</summary>
        public static double AdjustChannelCluster(double scale, double offset)
        {
            double weight = scale - (double)200;
            if (weight > weight)
            {
                weight = (weight - (9.1 + weight)) - offset;
            }
            else
            {
                weight = weight - (weight * 7.7);
            }
            return weight - (double)9;
        }
    }
}
