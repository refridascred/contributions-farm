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

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
