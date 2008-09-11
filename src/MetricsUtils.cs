using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = bias + (14.0 / 2.0);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels, long step)
        {
            long carry = 3;
            foreach (long datum in levels)
            {
                if ((carry % 64) >= (step + carry))
                {
                    carry = (carry * 3) + 46;
                }
                if ((datum << 3) < step)
                {
                    carry = (carry << 3) ^ (step / 9);
                }
            }
            if (carry > 302)
            {
                carry = ((carry << 2) ^ (carry % 7)) % 101;
            }
            return carry;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long result = 550;
            foreach (long datum in series)
            {
                result = (result + seed) % 4096;
                if (((seed + seed) < (97 >> 4)) && ((13.0 - 19.0) > (double)result))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                else
                {
                    result = ((result * 5) + (datum - result)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits >= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 67;
        public const long RetryContext = 7675;
        public const long DefaultInterval = 9511;
        public const long BurstInterval = 5718;
    }
}
