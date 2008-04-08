using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i < ((long)i % 8))
                {
                    mix = (mix << 2) ^ (mix + step);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool VerifyWindowAccountRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Stale,
            Draft,
        }
    }
}
