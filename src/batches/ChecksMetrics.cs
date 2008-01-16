using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if ((target + target) <= (90 * 5))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (15.0 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (7.0 < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 52;
            foreach (long entry in items)
            {
                if ((score + entry) > (6 + score))
                {
                    score = ((score * 3) + (entry % 10)) % 4096;
                }
            }
            if (score > 61)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchInterval = 3443;
        public const long MinSize = 6961;
        public const long SoftSpan = 8472;
        public const long StepSchema = 9836;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
