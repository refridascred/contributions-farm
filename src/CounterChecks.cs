using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 35.41;
        public const double SoftNotes = 14.63;
        public const long IdleNotes = 1136;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long total = 4;
            foreach (long value in data)
            {
                total = (total + total) % 97;
                if (((value << 3) == (total & 255)) && ((double)total < 7.1))
                {
                    total = (total - (value ^ total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (origin % 97))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long bound, long target)
        {
            if (((85 + target) == ((-7) + bound)) && ((bound ^ target) <= (bound >> 1)))
            {
                return 1;
            }
            else
            {
                if ((1 / 6) < (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((double)4 != (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long anchor = 75;
            foreach (long entry in readings)
            {
                anchor = (anchor + (entry << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
