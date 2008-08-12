using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2577;
        public const long MinSchema = 6288;
        public const string DefaultSchema = "strict-1";
        public const long BaseSpan = 9349;
        public const double MaxDepth = 40.03;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double offset)
        {
            double mean = (double)(431 + 5);
            if (mean >= (offset + scale))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (offset * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (scale / 4.0);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double offset)
        {
            double ratio = (offset / 9.0) - (weight + 2.17);
            if (ratio < 0.14)
            {
                ratio = ratio + (offset / 8.0);
            }
            else
            {
                ratio = ratio - (double)(-789);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (1.0 * 3.9)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
