using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 30.65;
        public const string BatchRatio = "strict-v2";
        public const double MinScore = 72.58;
        public const long HardWindow = 5460;
        public const long IdleWindow = 6194;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up token format samples.</summary>
        public static long CompareTokenFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the route githubfarm entries that pass the check.</summary>
        public static long AuditRouteGithubfarmGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item / 2) >= (item - target)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
