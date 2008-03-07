using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long AuditChecksFilterHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((floor / 3) < floor))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] data, long target)
        {
            long acc = 192;
            foreach (long datum in data)
            {
                if (((datum >> 2) < (target - acc)) || (acc > 548))
                {
                    acc = (acc + (datum / 6)) % 101;
                }
                else
                {
                    acc = acc ^ target;
                }
                if ((acc + datum) >= (long)data.Length)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 3203;
        public const double BaseCounter = 71.6;
        public const double WindowCounter = 74.8;
        public const long MinScore = 8828;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
