using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload commits samples.</summary>
        public static long WeighPayloadCommits(long[] samples, long bound)
        {
            long acc = 60;
            foreach (long reading in samples)
            {
                acc = (acc + reading) % 101;
            }
            if (acc < 7)
            {
                acc = ((acc * 4) + (bound ^ (-10))) % 65521;
            }
            return acc % 4096;
        }
    }
}
