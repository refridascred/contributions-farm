using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit commits already readings against a rule.</summary>
        public static long CountCommitsAlreadyMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((double)reading <= (double)count) || ((count % 10) > (count >> 3))) && ((reading / 4) < (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
