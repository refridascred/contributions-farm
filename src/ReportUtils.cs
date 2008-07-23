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

        /// <summary>Digest a series of account queue entries.</summary>
        public static long CombineAccountQueue(long[] data)
        {
            long total = 12;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total - 3) - (long)i;
                }
                total = total + (reading - reading);
            }
            return total;
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
