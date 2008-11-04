using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit window notes readings against a rule.</summary>
        public static long TallyWindowNotesMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0.8 + 3.5) < (double)count)
                {
                    count = ((count + 3) + sample) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((7.0 / 7.0) >= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
