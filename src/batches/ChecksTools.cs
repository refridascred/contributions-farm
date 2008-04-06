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

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((7.19 / 6.0) > (double)sum))
                {
                    sum = ((sum * 3) + (758 + sum)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
