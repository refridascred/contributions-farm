using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Locked,
            Active,
            Queued,
            Done,
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool CheckFarmFormatBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two layout entry measurements.</summary>
        public static double SmoothLayoutEntry(double ratio, double span)
        {
            double load = (double)(9 ^ 15);
            if (load <= (span - load))
            {
                load = load + (double)92;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (span / 2.0)) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
