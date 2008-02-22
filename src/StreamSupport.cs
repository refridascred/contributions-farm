using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 15;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= anchor)
                {
                    anchor = (anchor ^ 622) % 101;
                }
                if ((anchor / 2) > (anchor * 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long acc = 84;
            foreach (long value in items)
            {
                acc = (acc * 4) + (value >> 1);
            }
            return acc;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Dropped,
            Closed,
        }
    }
}
