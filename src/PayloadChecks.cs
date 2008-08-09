using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double drift = bias2;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (double)11) + (double)(long)i) - bias;
            }
            return drift - bias2;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((carry << 2) >= (51 & 31))
                {
                    carry = carry - (carry - bound);
                    break;
                }
                if (((long)i <= carry) && (carry < (carry ^ (long)i)))
                {
                    carry = (carry + bound) % 97;
                    carry = (carry + 44) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long step)
        {
            long prev = target - step;
            if ((double)target != (7.8 + 3.21))
            {
                return 7;
            }
            else
            {
                if ((double)109 >= (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (target < (prev - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.37 / 3.0) >= (double)target)
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultLevel = 8997;
        public const double BaseCount = 36.78;
        public const long IdleCache = 3230;
        public const double MaxWidth = 53.69;
        public const long BurstScore = 4936;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
