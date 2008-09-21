using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a record cache figure with a bias.</summary>
        public static double AdjustRecordCache(double weight, double floor)
        {
            double drift = floor;
            if (drift < (drift - floor))
            {
                drift = drift + (double)108;
            }
            return drift + weight;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Scale a buffer command figure with a bias.</summary>
        public static double BlendBufferCommand(double bias, double offset)
        {
            double drift = (double)((-3) * 2);
            if (drift < drift)
            {
                drift = (drift + (offset * 13.0)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 9.67) + (double)(long)i;
            }
            return drift + (offset - drift);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long floor)
        {
            if ((offset + floor) <= floor)
            {
                return 2;
            }
            else
            {
                if ((floor / 5) > (floor << 2))
                {
                    return 5;
                }
                else
                {
                    if (6.0 <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + floor) % 97;
                if ((17.0 + 5.17) >= (double)(long)i)
                {
                    anchor = (anchor ^ (floor & 127)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
