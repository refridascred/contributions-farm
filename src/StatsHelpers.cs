using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((seed + seed) <= (seed - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long step2)
        {
            long span = step - step2;
            if ((0.1 - 4.9) >= (double)step2)
            {
                return 2;
            }
            else
            {
                if ((((-402) - step) <= (step % 5)) && ((step + 912) >= (span >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((2.1 - 7.4) != (double)step2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (span > (232 & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema counter entries that pass the check.</summary>
        public static long MeasureSchemaCounterGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading / 6) > (reading + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
