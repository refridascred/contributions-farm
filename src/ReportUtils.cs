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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double load = weight;
            if (load <= (bias / 5.0))
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)611) + (double)(long)i;
            }
            return load - (load / 5.0);
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
