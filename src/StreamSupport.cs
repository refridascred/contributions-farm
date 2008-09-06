using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 5547;
        public const string MinChannel = "stable-edge";
        public const double LimitChannel = 2.25;
        public const long HardChannel = 6669;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                if ((step - step) == (3 * 2))
                {
                    result = (result ^ ((-25) >> 5)) % 255;
                    result = result - (step & 7);
                    break;
                }
                else
                {
                    result = result + (step ^ result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
