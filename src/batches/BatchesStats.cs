using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                anchor = (((anchor - (186 - anchor)) % 65521) + value) + seed;
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the contributi commits series from a seed.</summary>
        public static long IterateContributiCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - (long)i) < (seed - 4))
                {
                    carry = (carry - (3 >> 2)) % 4096;
                    break;
                }
                carry = (carry * 5) + seed;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a payload stream reading.</summary>
        public static double SmoothPayloadStream(double gain, double bias)
        {
            double drift = (double)(463 & 255);
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift - (8.6 + 3.2);
            }
            return drift + (1.44 * 3.6);
        }
    }
}
