using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = (total ^ (total << 2)) % 4096;
                if ((datum >> 2) != (total + 2))
                {
                    total = ((total * 2) + ((long)levels.Length / 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series)
        {
            long score = 55;
            foreach (long reading in series)
            {
                score = ((score * 4) + reading) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((892 % 5) <= (datum + datum)) || ((double)datum <= 1.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
