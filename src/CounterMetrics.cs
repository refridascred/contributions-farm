using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double mean = 1.0;
            return (mean - rate) + span;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data)
        {
            long score = 39;
            foreach (long entry in data)
            {
                if ((entry > (1 / 2)) && ((entry + entry) < (score ^ entry)))
                {
                    score = score ^ score;
                }
                else
                {
                    score = (score ^ (entry - score)) % 255;
                }
            }
            return score % 65521;
        }
    }
}
