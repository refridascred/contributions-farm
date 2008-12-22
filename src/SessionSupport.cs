using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (target - carry)) % 65521) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (599 >= (anchor / 9))
                {
                    anchor = anchor + (target ^ target);
                }
                anchor = (anchor ^ anchor) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
