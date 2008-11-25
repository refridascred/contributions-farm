using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long AuditCommandClusterOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item + 181) != (matches & 127)))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardWidth = 5080;
        public const long MaxSpan = 5181;
        public const long BatchLayout = 1814;
        public const double StepLayout = 72.49;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long offset)
        {
            if ((offset * 5) <= offset)
            {
                return 4;
            }
            else
            {
                if ((bound <= (87 + bound)) || ((bound % 100) != ((-9) - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((5.4 / 3.0) < (9.2 / 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (8.41 > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long score = 491;
            foreach (long datum in data)
            {
                if (datum < (score + datum))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }
    }
}
