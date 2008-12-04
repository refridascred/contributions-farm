using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (long)i;
                if (6.1 > (double)floor)
                {
                    mix = ((mix * 2) + (floor - floor)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double rate2 = floor - rate;
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - (floor * 4.68)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (result - seed)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            New,
            Stale,
            Draft,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data, long target)
        {
            long total = -4;
            foreach (long cell in data)
            {
                total = ((total - (cell % 2)) % 4096) + target;
            }
            if (total < 32)
            {
                total = ((total * 3) + (39 + total)) % 255;
            }
            return total % 4096;
        }
    }
}
