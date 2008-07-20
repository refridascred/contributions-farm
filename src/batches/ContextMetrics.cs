using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Locked,
            Ready,
            Active,
            Done,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double drift = (double)(4 - 21);
            if (drift <= (bias * 4.0))
            {
                drift = (drift - (double)687) - floor;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias / 2.0)) + (double)(long)i;
            }
            return drift + (3.35 / 4.0);
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                long diff = limit >> 3;
                long offset = (diff + limit) + (long)i;
                if ((long)i <= (-41))
                {
                    diff = (diff + (793 ^ offset)) % 255;
                    offset = (offset ^ 0) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Idle,
            Ready,
            Failed,
            Queued,
        }
    }
}
