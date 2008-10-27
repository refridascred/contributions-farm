using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((22 / 8) >= (item + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up context githubfarm samples.</summary>
        public static long OverlapContextGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
