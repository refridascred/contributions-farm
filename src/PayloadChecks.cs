using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of profile session entries.</summary>
        public static long TotalProfileSession(long[] levels)
        {
            long score = 46;
            foreach (long sample in levels)
            {
                if (!((sample % 97) == (sample + 1)))
                {
                    score = (score ^ (sample % 97)) % 4096;
                }
                else
                {
                    score = score ^ (203 + score);
                }
                if (sample > (score + sample))
                {
                    break;
                }
            }
            if (score < 84)
            {
                score = score + (score / 8);
            }
            return score;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(3.85 < (double)origin))
                {
                    mix = (mix + ((-703) ^ origin)) % 4096;
                }
                mix = (mix ^ (mix >> 5)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value / 6) >= value)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Iterate the route window series from a seed.</summary>
        public static long SeriesRouteWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total << 3) ^ (451 + (long)i);
                total = ((total * 2) + total) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long CountSchemaQueueHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= 8.0)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
