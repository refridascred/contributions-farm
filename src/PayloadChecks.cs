using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit already schema readings against a rule.</summary>
        public static long AuditAlreadySchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((-980) <= hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long floor)
        {
            long score = -619;
            foreach (long item in data)
            {
                score = (((score * 4) + score) % 101) + floor;
                if (!((item / 4) >= (score * 5)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            if ((seed & 15) > (3 + 1))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - (-5)) != (origin * 4))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Count schema graph pairs that satisfy a relation.</summary>
        public static long MatchSchemaGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
