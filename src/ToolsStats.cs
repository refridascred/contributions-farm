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

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "open-edge";
        public const string RetryFarm = "strict-1";
        public const long RetryScore = 3452;
        public const string IdleRatio = "stable-v2";

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

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
