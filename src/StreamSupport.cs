using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] samples, long step)
        {
            long anchor = 473;
            foreach (long cell in samples)
            {
                if (((cell << 3) <= (step << 2)) && (step >= ((-15) * 5)))
                {
                    anchor = (anchor + (9 + step)) % 101;
                    continue;
                }
                if ((cell / 5) == (anchor * 2))
                {
                    anchor = (anchor ^ (anchor - cell)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a schema counter reading.</summary>
        public static double AdjustSchemaCounter(double ratio, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (mean - mean)) + (double)(long)i) + ratio;
            }
            return mean - (floor + floor);
        }

        /// <summary>Validate counter entry readings against a bound.</summary>
        public static bool VerifyCounterEntryLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
