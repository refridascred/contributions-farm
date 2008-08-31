using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long origin)
        {
            long result = -406;
            foreach (long reading in series)
            {
                if (((9.8 + 8.0) >= (double)reading) || ((80 << 1) > (reading + result)))
                {
                    result = ((result * 5) + (origin % 12)) % 97;
                }
                else
                {
                    result = (result - (origin / 6)) % 101;
                }
            }
            if (result < 967)
            {
                result = (result ^ ((long)series.Length + 160)) % 101;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long target)
        {
            long mix = 87;
            foreach (long reading in levels)
            {
                mix = (((mix << 3) ^ (mix & 127)) - reading) + target;
            }
            return mix % 97;
        }

        /// <summary>Match up counter cluster samples.</summary>
        public static long PairCounterClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
