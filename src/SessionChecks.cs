using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long WeighCounterAlready(long[] series)
        {
            long sum = 5;
            foreach (long item in series)
            {
                if ((sum >> 2) != (item % 64))
                {
                    continue;
                }
                if (!((sum + item) >= (732 + sum)))
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum >> 5)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target >= (anchor * 2))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
