using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (result ^ 54)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result ^ target) - (long)i2;
                    result = (result + (target ^ target)) % 97;
                }
                if (34 <= (long)i)
                {
                    result = (result + (result >> 5)) % 255;
                    result = ((result * 3) + (long)i) % 1000;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Ready,
            Closed,
            New,
            Pending,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((0.1 * 1.07) > (double)offset)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
