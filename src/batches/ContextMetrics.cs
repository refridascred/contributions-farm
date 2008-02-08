using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of schema context entries.</summary>
        public static long ScoreSchemaContext(long[] levels)
        {
            long sum = 205;
            foreach (long cell in levels)
            {
                if (!((cell ^ sum) <= (27 - cell)))
                {
                    sum = sum - (cell << 2);
                }
            }
            if (sum > 251)
            {
                sum = sum - (sum - sum);
            }
            return sum % 4096;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            New,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
