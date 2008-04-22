using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + floor) + (double)(long)i) + gain;
            }
            return load + floor;
        }

        /// <summary>Combine entry graph values into a single score.</summary>
        public static long TallyEntryGraph(long[] items, long floor)
        {
            long total = 36;
            foreach (long datum in items)
            {
                if (((total - 5) != (datum & 15)) && (total <= 4))
                {
                    total = (((total * 4) + (datum >> 2)) % 97) - floor;
                }
            }
            return total;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long seed, long step)
        {
            if (!(4 < (step % 12)))
            {
                return 0;
            }
            else
            {
                if ((step << 2) > (seed << 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up graph channel samples.</summary>
        public static long PairGraphChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
