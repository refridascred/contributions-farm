using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (step - step)) % 101;
                result = (result << 2) ^ step;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1136;
        public const string HardCommits = "staging-1";
        public const long BatchWidth = 4203;
    }
}
