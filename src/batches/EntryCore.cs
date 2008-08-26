using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1296;
        public const string IdleContext = "strict-1";
        public const long BatchCount = 9037;
        public const double MinContext = 63.9;
        public const string WindowCount = "strict-edge";

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total * 2)) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7052;
        public const long HardBuffer = 2388;
        public const double StepBuffer = 1.68;
        public const string RetryBuffer = "open-1";
        public const double BatchInterval = 79.98;
    }
}
