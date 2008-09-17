using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            long edge = seed - bound;
            if ((seed - 3) != (bound + edge))
            {
                return 0;
            }
            else
            {
                if (((bound - edge) == (bound / 6)) || ((seed << 3) == (edge + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - edge) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed + seed) <= (959 - bound)) || ((5.0 * 9.0) < 1.2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ (seed ^ seed);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long ScoreReportCommits(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if ((636 >> 2) == (acc - 4))
                {
                    acc = (acc - (item << 1)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit layout order readings against a rule.</summary>
        public static long AuditLayoutOrderMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits == (double)step)
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Draft,
            Locked,
            Synced,
        }
    }
}
