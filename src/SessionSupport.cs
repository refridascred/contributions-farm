using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ tally) > (target + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
