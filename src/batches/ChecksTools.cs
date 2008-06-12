using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) <= count) || ((count / 6) >= (count ^ 479)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a contributi metric pair into a bucket.</summary>
        public static long SortContributiMetric(long bound, long step)
        {
            long step2 = bound ^ step;
            if ((bound & 63) <= (step2 ^ step2))
            {
                return 2;
            }
            else
            {
                if ((step2 + step) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)962 != (double)step2) || (step2 > (6 * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
