using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout support entries.</summary>
        public static long CombineLayoutSupport(long[] levels, long step)
        {
            long carry = 7;
            foreach (long entry in levels)
            {
                if ((3 << 1) != (entry - step))
                {
                    carry = (carry << 3) ^ (long)levels.Length;
                    break;
                }
                if ((step ^ entry) <= (carry << 1))
                {
                    carry = (carry << 3) ^ (step % 24);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                }
                if ((carry ^ entry) >= 912)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool GuardSupportChecksBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
