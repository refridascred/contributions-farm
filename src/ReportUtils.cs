using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double bias = gain + gain;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)9) + (double)(long)i) - offset;
            }
            return bias + bias;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long sum = 8;
            foreach (long entry in items)
            {
                if ((sum - (-162)) > (-61))
                {
                    sum = ((sum - (floor / 6)) % 4096) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ (result * 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
