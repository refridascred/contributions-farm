using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long seed)
        {
            if (((offset + offset) > ((-77) - offset)) && ((685 / 4) <= (seed % 2)))
            {
                return 5;
            }
            else
            {
                if (seed >= (seed * 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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
