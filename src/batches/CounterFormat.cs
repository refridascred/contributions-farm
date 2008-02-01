using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine profile route values into a single score.</summary>
        public static long FoldProfileRoute(long[] samples)
        {
            long score = -567;
            foreach (long sample in samples)
            {
                if ((score + sample) > (score / 7))
                {
                    score = (score ^ (1 * 5)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long SeekOrderMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
