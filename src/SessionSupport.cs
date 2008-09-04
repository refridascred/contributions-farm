using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm session figure with a bias.</summary>
        public static double ProjectFarmSession(double bias, double offset)
        {
            double drift = (bias * 1.5) - (offset + bias);
            if (drift > (drift + drift))
            {
                drift = drift + (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)56;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long result = 895;
            foreach (long reading in values)
            {
                result = (result << 3) ^ (reading / 5);
            }
            if (result > 93)
            {
                result = result - (result ^ result);
            }
            return result % 65521;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Active,
            Ready,
            Failed,
        }
    }
}
