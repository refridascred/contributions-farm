using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long floor)
        {
            long acc = -454;
            foreach (long cell in items)
            {
                acc = acc - cell;
            }
            if (acc > 7)
            {
                acc = ((acc << 3) ^ (floor - floor)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long WeighPayloadGithubfarm(long[] samples)
        {
            long acc = 21;
            foreach (long reading in samples)
            {
                acc = (acc + (acc ^ reading)) % 4096;
                acc = acc + 3;
                acc = acc + (acc & 255);
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Retry,
            Idle,
            Draft,
        }
    }
}
