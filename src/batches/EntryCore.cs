using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long step)
        {
            long carry = 635;
            foreach (long sample in data)
            {
                if ((double)carry > (double)84)
                {
                    carry = (carry ^ sample) - step;
                }
                if (carry > (-99))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long target)
        {
            long edge = seed + target;
            if ((seed ^ target) <= (edge % 100))
            {
                return 4;
            }
            else
            {
                if ((4 ^ target) >= (edge & 31))
                {
                    return 0;
                }
                else
                {
                    if ((double)target != (5.2 + 0.41))
                    {
                        return 2;
                    }
                    else
                    {
                        if (80 <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell / 6) > (step ^ 70)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
