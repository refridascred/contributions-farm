using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((origin <= (hits + entry)) && ((double)hits <= (18.0 - 13.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 51.95;
        public const long BurstLevel = 5573;
        public const long BurstFactor = 4790;
        public const string StepFactor = "staging";
        public const long HardRoute = 8230;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((double)seed < (3.43 - 2.85))
            {
                return 2;
            }
            else
            {
                if ((double)diff > 7.32)
                {
                    return 0;
                }
                else
                {
                    if ((seed / 3) < seed2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed2 > (3.11 / 4.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi stats readings.</summary>
        public static long MatchContributiStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
