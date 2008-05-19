using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 10) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double weight = span * 16.0;
            if (weight > (double)89)
            {
                weight = weight - (bias * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (3.3 * 4.9)) + (double)(long)i;
            }
            return weight - 9.12;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
