using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Project the next stream cluster value.</summary>
        public static double BlendStreamCluster(double gain, double floor)
        {
            double gain2 = 15.0;
            return ((gain2 - (gain2 / 7.0)) + gain) + floor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - acc) % 97;
                if ((double)(long)i < (2.23 + 0.93))
                {
                    acc = (acc << 3) ^ (acc / 2);
                    acc = ((acc * 3) + (795 + floor)) % 65521;
                    continue;
                }
                else
                {
                    acc = (acc ^ acc) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate entry already samples.</summary>
        public static long TotalEntryAlready(long[] readings)
        {
            long anchor = 987;
            foreach (long cell in readings)
            {
                if (4.01 <= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ cell)) % 97;
                }
            }
            return anchor % 65521;
        }
    }
}
