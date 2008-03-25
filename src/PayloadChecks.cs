using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 2.24;
        public const long HardToken = 3117;
        public const double StepCount = 83.94;
        public const long MinToken = 350;
        public const string SoftSize = "open-v2";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            long edge = limit ^ origin;
            if (origin >= (limit ^ edge))
            {
                return 4;
            }
            else
            {
                if (((double)limit >= (double)origin) && ((origin & 3) < edge))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            New,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double gain = (double)(-819) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - scale) + (double)(long)i) + offset;
            }
            return gain + scale;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long mark = 552;
            foreach (long entry in data)
            {
                mark = ((mark - mark) % 97) ^ entry;
            }
            return mark;
        }
    }
}
