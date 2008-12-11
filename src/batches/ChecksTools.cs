using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc << 1);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a layout order figure with a bias.</summary>
        public static double ProjectLayoutOrder(double gain, double span)
        {
            double gain2 = span;
            return (gain2 + span) + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 9920;
        public const long BatchReport = 5670;
        public const long LimitInterval = 2507;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long floor)
        {
            if ((floor + step) <= floor)
            {
                return 1;
            }
            else
            {
                if ((step - step) > (step & 15))
                {
                    return 8;
                }
                else
                {
                    if ((step / 7) < (floor % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
