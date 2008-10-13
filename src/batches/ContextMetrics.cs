using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double span)
        {
            double ratio2 = span;
            return (ratio2 + span) + ratio;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Closed,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches / 5) <= (matches >> 2))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of entry schema readings.</summary>
        public static long PairEntrySchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
