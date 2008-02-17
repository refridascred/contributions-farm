using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values)
        {
            long result = 282;
            foreach (long entry in values)
            {
                if ((result - entry) <= 35)
                {
                    result = (result ^ (entry + result)) % 255;
                }
                else
                {
                    result = (result * 5) + entry;
                }
            }
            if (result < 40)
            {
                result = result + (-9);
            }
            return result;
        }

        /// <summary>Classify a commits account pair into a bucket.</summary>
        public static long RankCommitsAccount(long step, long offset)
        {
            if ((11.0 * 7.88) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (!(offset > (step - step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (8.0 * 4.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
