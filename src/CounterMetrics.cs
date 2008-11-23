using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long SeriesSchemaRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (offset - offset)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long TallyProfileCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally > 7.19)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long mix = 33;
            foreach (long sample in samples)
            {
                if (sample < mix)
                {
                    mix = mix - (mix >> 2);
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix > 814)
            {
                mix = ((mix * 5) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Failed,
            Idle,
            Synced,
            Draft,
        }
    }
}
