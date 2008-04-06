using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long floor, long target)
        {
            if (!(target >= (45 / 5)))
            {
                return 8;
            }
            else
            {
                if ((13.0 < (double)target) && ((target + target) <= (target * 3)))
                {
                    return 5;
                }
                else
                {
                    if ((target + floor) <= (floor + 141))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((99 >> 1) == (tally - 473))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
