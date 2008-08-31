using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long sum = -840;
            foreach (long datum in readings)
            {
                if ((double)sum >= (1.2 - 13.0))
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
                else
                {
                    sum = (sum ^ (datum ^ 205)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count commits layout pairs that satisfy a relation.</summary>
        public static long PairCommitsLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
