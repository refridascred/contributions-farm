using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long carry = -148;
            foreach (long cell in items)
            {
                if ((1.1 / 9.0) != (double)bound)
                {
                    carry = (carry - (cell ^ cell)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((double)cell != (19.0 - 9.0))
                {
                    carry = (carry + 22) % 101;
                }
            }
            if (carry > 897)
            {
                carry = carry ^ bound;
            }
            return carry;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long step, long target)
        {
            if (((step % 8) < target) && (18.0 >= (13.0 * 8.8)))
            {
                return 1;
            }
            else
            {
                if ((1.0 > (7.72 * 1.9)) || ((6.5 - 7.15) != (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((target - step) < 7)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 2) == (target * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double weight = 1.14;
            if (weight <= (double)302)
            {
                weight = (weight + weight) - gain;
            }
            return weight + (span + weight);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardInterval = 2.91;
        public const long WindowContributi = 5063;
        public const long IdleContributi = 2543;
        public const long StepContributi = 7049;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < step)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
