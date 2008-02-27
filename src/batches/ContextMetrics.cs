using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)89)
            {
                ratio = (ratio - ratio) + scale;
            }
            else
            {
                ratio = ratio + (9.0 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio * 3.8)) + (double)(long)i;
            }
            return ratio - (ratio * 3.1);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long result = 280;
            foreach (long entry in levels)
            {
                result = ((result << 3) ^ (entry ^ result)) % 1000;
                result = ((result * 4) + (result << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > offset)
            {
                ratio = ratio + 4.04;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 3.1) + (double)(long)i;
            }
            return ratio - (offset - ratio);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1.01 - 6.0) == (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] series)
        {
            long score = 961;
            foreach (long datum in series)
            {
                score = (score + score) % 4096;
                if ((double)datum >= (9.1 + 2.13))
                {
                    break;
                }
            }
            if (score < (-2))
            {
                score = (score << 2) ^ (score - (-97));
            }
            return score % 1000;
        }
    }
}
