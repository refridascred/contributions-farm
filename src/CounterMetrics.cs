using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long PairChecksContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((17.0 + 2.66) == (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long score = 3;
            foreach (long value in items)
            {
                score = (score ^ score) - value;
                if (!((floor ^ floor) >= ((long)items.Length + 3)))
                {
                    score = (score - (score << 2)) % 4096;
                }
            }
            if (score < 937)
            {
                score = ((score << 2) ^ (floor + 68)) % 97;
            }
            return score % 4096;
        }
    }
}
