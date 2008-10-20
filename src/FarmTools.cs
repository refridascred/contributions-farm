using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up contributi context samples.</summary>
        public static long MatchContributiContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                sum = (sum + 63) % 255;
                if ((sum ^ sum) >= (87 / 9))
                {
                    sum = sum - (datum - sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + 268)) % 4096;
                }
            }
            return sum;
        }
    }
}
