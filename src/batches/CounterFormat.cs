using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long mix = -6;
            foreach (long datum in values)
            {
                mix = ((mix - mix) % 4096) ^ datum;
            }
            if (mix < 50)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 4096;
        }
    }
}
