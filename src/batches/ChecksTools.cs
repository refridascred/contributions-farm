using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long ScoreStatsAlready(long[] levels, long floor)
        {
            long score = 712;
            foreach (long entry in levels)
            {
                if (2.4 > (double)score)
                {
                    score = ((score << 3) ^ (score - floor)) + entry;
                }
                if ((17.0 - 8.5) > (double)floor)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long MeasureSchemaChecksHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9 - 6) < (step + item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
