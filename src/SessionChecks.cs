using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the stats report series from a seed.</summary>
        public static long DeriveStatsReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ ((long)i - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (rate - floor))
            {
                drift = drift - 7.68;
            }
            else
            {
                drift = drift + (6.4 / 7.0);
            }
            return drift - (floor - 2.6);
        }
    }
}
