using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double load = (5.0 + bias) * 9.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - bias) + (double)(long)i) - weight;
            }
            return load + (load * 3.0);
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long StepToolsQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if (((sum ^ sum) > sum) && ((18.0 * 19.0) < (double)step))
                {
                    sum = ((sum << 2) ^ step) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Idle,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Blend two stream stats measurements.</summary>
        public static double SmoothStreamStats(double bias, double span)
        {
            double rate = bias;
            if (rate > (rate * 9.0))
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (double)541;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Stale,
            New,
            Failed,
        }
    }
}
