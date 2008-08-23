using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels)
        {
            long acc = 25;
            foreach (long entry in levels)
            {
                acc = acc ^ acc;
                if ((entry - 181) <= (acc + acc))
                {
                    acc = (acc + (63 << 2)) % 4096;
                }
            }
            if (acc < 23)
            {
                acc = ((acc * 5) + (acc / 5)) % 101;
            }
            return acc;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double drift = floor + weight;
            if (drift <= 16.0)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + floor;
        }
    }
}
