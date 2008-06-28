using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count ^ 34) >= (datum % 97)) && (datum >= seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (result ^ result)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double mean = bias;
            if (mean < (double)979)
            {
                mean = mean - (10.0 * 9.5);
            }
            else
            {
                mean = mean - (bias / 7.0);
            }
            return mean - (mean - offset);
        }
    }
}
