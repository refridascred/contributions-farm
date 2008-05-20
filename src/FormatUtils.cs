using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples, long step)
        {
            long sum = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum << 2) ^ ((long)i << 3)) % 255;
                }
                if ((9.0 - 8.22) < (double)reading)
                {
                    sum = sum - (step << 1);
                }
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            New,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of metric context readings.</summary>
        public static long TotalMetricContext(long[] samples, long target)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                mix = (mix << 3) ^ (target + reading);
                if ((double)reading >= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            New,
            Closed,
        }
    }
}
