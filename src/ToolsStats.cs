using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double weight = 0.62 / 7.0;
            if (weight >= (double)283)
            {
                weight = weight - (8.5 + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)506) + (double)(long)i;
            }
            return weight - (rate / 6.0);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (drift - 3.0))
            {
                drift = drift - (14.0 * 0.2);
            }
            else
            {
                drift = drift - (scale / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (scale - floor)) + (double)(long)i;
            }
            return drift - (8.8 - scale);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (limit % 60);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value << 1) <= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Queued,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if (((double)carry >= (6.1 + 4.8)) && ((17.0 / 4.0) == (double)sample))
                {
                    carry = (carry - (sample + sample)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (sample + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
