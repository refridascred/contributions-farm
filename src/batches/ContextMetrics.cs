using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 69;
            foreach (long reading in series)
            {
                if ((seed & 3) >= (reading ^ seed))
                {
                    acc = acc + (3 + seed);
                }
                else
                {
                    acc = (acc + (seed * 5)) % 1000;
                }
            }
            if (acc < 61)
            {
                acc = ((acc << 3) ^ seed) % 255;
            }
            return acc;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double rate, double offset)
        {
            double mean = 7.85;
            if (mean <= (double)727)
            {
                mean = ((mean - mean) - rate) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)99) + (double)(long)i;
            }
            return mean + 9.52;
        }
    }
}
