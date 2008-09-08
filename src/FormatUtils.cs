using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((87 ^ state) < 60)
                {
                    long prev = state + (target - state);
                    state = ((state << 2) ^ (prev - 2)) % 97;
                }
                state = ((state * 4) + ((long)i ^ target)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long bound)
        {
            long carry = 64;
            foreach (long sample in data)
            {
                carry = ((carry ^ (bound - (-52))) % 101) + sample;
            }
            if (carry > 39)
            {
                carry = (carry ^ bound) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            New,
            Queued,
            Failed,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
