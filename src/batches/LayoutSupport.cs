using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats githubfarm value from a seed.</summary>
        public static long RollStatsGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + (limit / 6)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length + entry) <= (entry / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (1.49 + 1.6))
            {
                drift = drift - 1.6;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift + floor)) + (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
