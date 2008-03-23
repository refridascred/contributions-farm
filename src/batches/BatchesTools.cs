using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double weight = (bias - bias2) - (bias * 2.4);
            if (weight <= (double)751)
            {
                weight = weight - (bias2 / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight - bias)) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Stale,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
