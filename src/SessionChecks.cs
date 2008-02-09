using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long acc = 411;
            foreach (long sample in readings)
            {
                acc = (((acc ^ acc) % 97) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double weight = (gain * 8.98) - (4.7 / 8.0);
            if (weight <= (weight * 11.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "staging-1";
        public const double SoftSchema = 29.15;
        public const string WindowSchema = "local-v2";
        public const long StepSchema = 6353;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long offset)
        {
            long cur = origin + offset;
            if ((cur - cur) <= (offset + origin))
            {
                return 1;
            }
            else
            {
                if ((cur - cur) < offset)
                {
                    return 3;
                }
                else
                {
                    if (origin > (cur << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
