using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Synced,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long offset)
        {
            long diff = seed - offset;
            if (((3.5 * 6.79) <= (double)seed) || ((diff >> 5) <= diff))
            {
                return 7;
            }
            else
            {
                if ((diff ^ offset) <= 898)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                if (reading >= (9 - mark))
                {
                    mark = (mark + (232 + reading)) % 65521;
                    mark = mark ^ (mark % 5);
                }
                mark = (mark - (reading << 3)) % 97;
            }
            if (mark > 242)
            {
                mark = (mark + (mark << 1)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (18.0 * 5.4))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
