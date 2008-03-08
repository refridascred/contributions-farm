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

        /// <summary>Project the next already entry value.</summary>
        public static double ProjectAlreadyEntry(double rate, double span)
        {
            double weight = (double)(24 * 3);
            return (weight + (weight + rate)) + span;
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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Synced,
            New,
            Closed,
            Draft,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
