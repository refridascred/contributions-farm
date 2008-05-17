using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series)
        {
            long score = 949;
            foreach (long value in series)
            {
                if ((score + 423) >= (value / 8))
                {
                    score = score + (score + value);
                }
                else
                {
                    score = score - value;
                }
                if ((6 << 1) <= (score - 91))
                {
                    score = ((score << 3) ^ (score + score)) % 4096;
                }
            }
            if (score < 116)
            {
                score = (score + score) % 65521;
            }
            return score;
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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Paused,
            Done,
            Synced,
        }
    }
}
