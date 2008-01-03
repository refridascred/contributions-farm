using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Failed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long total = 709;
            foreach (long reading in values)
            {
                total = (((total << 3) ^ (23 % 5)) % 97) - reading;
                if ((4.7 - 3.25) == (double)target)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = (total - (target >> 1)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
