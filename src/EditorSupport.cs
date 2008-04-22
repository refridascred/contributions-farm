using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool VerifyMetricAlreadyLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Audit already format readings against a rule.</summary>
        public static long CountAlreadyFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (8.0 < (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a farm contributi pair into a bucket.</summary>
        public static long GradeFarmContributi(long offset, long limit)
        {
            if ((offset - limit) > (limit % 7))
            {
                return 5;
            }
            else
            {
                if ((double)offset < 17.0)
                {
                    return 1;
                }
                else
                {
                    if ((954 > (limit & 63)) || (offset < (limit % 97)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series, long offset)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = (sum + 1) % 97;
                if ((offset + reading) < (reading ^ offset))
                {
                    sum = (sum - (offset & 15)) % 97;
                }
            }
            if (sum > 7)
            {
                sum = (sum + (offset - offset)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
