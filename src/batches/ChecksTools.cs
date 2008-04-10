using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token command readings against a bound.</summary>
        public static bool CheckTokenCommandRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
