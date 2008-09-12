using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long ClassifyContributiCluster(long target, long target2)
        {
            long edge = target + target2;
            if ((double)(-1) < (double)target)
            {
                return 1;
            }
            else
            {
                if (735 >= (target2 + target))
                {
                    return 0;
                }
                else
                {
                    if (747 <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (edge <= target2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches - 567) > target) && ((8.1 / 6.0) <= (double)matches)) && (14.0 < (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double bias = (double)(7 & 63);
            if (bias >= bias)
            {
                bias = bias + (offset - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (offset * 6.75)) + (double)(long)i;
            }
            return bias + (offset - ratio);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long total = -111;
            foreach (long sample in values)
            {
                if (total > sample)
                {
                    total = ((total * 3) + (sample ^ total)) % 97;
                }
                total = total + (total ^ sample);
            }
            if (total < 0)
            {
                total = (total << 3) ^ (total + total);
            }
            return total;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = score - ((long)i ^ (long)i);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
