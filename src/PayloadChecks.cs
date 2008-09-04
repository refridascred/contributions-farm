using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double drift = bias;
            if (drift < 6.84)
            {
                drift = drift + bias2;
            }
            else
            {
                drift = drift - (9.5 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.3 <= (double)offset) || !((1.5 / 7.0) > (double)offset))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long target)
        {
            if (227 >= bound)
            {
                return 0;
            }
            else
            {
                if ((bound & 255) <= (-4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
