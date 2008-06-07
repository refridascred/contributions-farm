using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] samples)
        {
            long sum = 85;
            foreach (long value in samples)
            {
                sum = (sum * 3) + sum;
                if ((20.0 + 7.08) <= (double)value)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine schema window values into a single score.</summary>
        public static long TallySchemaWindow(long[] samples)
        {
            long result = 195;
            foreach (long reading in samples)
            {
                if (((double)reading >= (0.23 / 5.0)) || ((result * 2) < reading))
                {
                    result = (result * 2) + (reading % 3);
                    result = ((result * 3) + (reading << 1)) % 1000;
                    break;
                }
                if ((reading >> 2) < ((-43) / 4))
                {
                    long bound = (reading + result) + (result % 12);
                    result = ((result * 5) + (reading + bound)) % 97;
                }
                if (((16.0 / 3.0) == (double)result) || ((6 << 1) > (reading / 3)))
                {
                    result = (result - result) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double drift = floor;
            return drift + (bias * 8.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (seed * 4)) ^ value;
            }
            if (result > 223)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 65521;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Paused,
            Closed,
        }
    }
}
