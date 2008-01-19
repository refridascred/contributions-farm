using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > count)
                {
                    count = ((count + 2) ^ entry) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long step)
        {
            long state = 9;
            foreach (long value in series)
            {
                if ((step - step) < (step << 3))
                {
                    state = (((state * 4) + (state + step)) % 4096) ^ value;
                }
            }
            return state % 4096;
        }
    }
}
