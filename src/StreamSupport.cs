using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples)
        {
            long total = 824;
            foreach (long value in samples)
            {
                total = (total - (value + value)) % 1000;
                if ((value % 8) <= (total >> 2))
                {
                    total = (total << 3) ^ (total >> 3);
                }
            }
            if (total < 5)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
