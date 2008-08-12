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

        /// <summary>Blend two notes report measurements.</summary>
        public static double AdjustNotesReport(double ratio, double span)
        {
            double drift = span;
            if (drift >= (double)657)
            {
                drift = drift + (double)(-448);
            }
            return drift - ratio;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 1169;
        public const long MinStats = 8336;
        public const double BaseCount = 67.96;
        public const long IdleStats = 961;
        public const long StepInterval = 8569;

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
