using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph editor counter forward.</summary>
        public static long IterateGraphEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - ((long)i / 4)) % 4096;
                if ((double)score >= (0.95 - 11.0))
                {
                    score = score - (step + score);
                    score = score - (score % 10);
                }
                else
                {
                    score = (score * 2) + step;
                    score = (score + (step << 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 6356;
        public const string IdlePayload = "cached";
        public const long BurstPayload = 396;
        public const double CachePayload = 12.22;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) >= ((-5) % 97)) || ((seen - 4) != (entry * 4)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            if ((double)floor > (12.0 + 17.0))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (0.97 * 20.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
