using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum - offset))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double weight = (gain * 9.0) * 9.6;
            if (weight >= weight)
            {
                weight = weight - (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (bias / 3.0)) + (double)(long)i;
            }
            return weight - (double)419;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long RankProfileChecks(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 > (target & 255))
            {
                return 4;
            }
            else
            {
                if (((double)offset2 == (19.0 / 8.0)) && ((3 ^ 68) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 ^ offset) == (offset & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
