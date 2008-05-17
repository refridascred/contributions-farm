using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Retry,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two profile filter measurements.</summary>
        public static double SmoothProfileFilter(double scale, double bias)
        {
            double rate = bias;
            return (rate + (double)(-398)) + scale;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double drift = (double)(944 + (-8));
            return ((drift - drift) + gain) + span;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long target)
        {
            long sum = 42;
            foreach (long entry in samples)
            {
                if (8.29 <= (double)target)
                {
                    sum = (sum ^ (sum << 2)) ^ entry;
                }
                else
                {
                    sum = (sum * 5) + (sum % 10);
                }
            }
            return sum;
        }
    }
}
