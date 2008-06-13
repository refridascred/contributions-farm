using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 3) ^ (origin + origin)) % 65521;
                result = ((result << 3) ^ (result + (long)i)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Failed,
            Active,
            Locked,
            Dropped,
        }
    }
}
