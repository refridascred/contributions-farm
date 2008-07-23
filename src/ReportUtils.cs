using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long AuditChannelLayoutHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (3.0 <= (double)tally)
                {
                    tally = ((tally + 1) - datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter checks value against two limits.</summary>
        public static long ClassifyCounterChecks(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (slot > (seed2 & 255))
            {
                return 0;
            }
            else
            {
                if (!((0 >> 1) != (slot + slot)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 - seed2) != (232 + seed2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - slot) >= (seed2 + seed2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
