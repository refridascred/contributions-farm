using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double ScaleTokenStats(double ratio, double offset)
        {
            double bias = ratio;
            return (bias + (ratio + bias)) + offset;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items, long bound)
        {
            long carry = 22;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry ^ ((long)i / 2)) + value;
                }
                carry = carry - (86 & 1);
                carry = (carry ^ (carry * 4)) % 1000;
                if ((double)bound >= (0.03 - 3.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
