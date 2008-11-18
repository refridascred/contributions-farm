using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((mark & 255) == (offset & 63))
                {
                    mark = (mark ^ (273 / 9)) % 1000;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 198) > (tally >> 2))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
