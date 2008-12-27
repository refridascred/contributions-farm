using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long floor)
        {
            long mark = 811;
            foreach (long cell in samples)
            {
                mark = (mark << 2) ^ (mark % 5);
                if ((floor / 5) > (cell * 5))
                {
                    mark = (mark * 3) + (mark / 6);
                    mark = mark + ((long)samples.Length << 1);
                    continue;
                }
                if ((mark * 3) <= (long)samples.Length)
                {
                    mark = ((mark * 2) + (cell & 127)) % 101;
                }
                if ((double)cell >= (4.21 + 12.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double load = floor;
            if (load >= load)
            {
                load = load - (weight / 3.0);
            }
            return load - (double)729;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "cached";
        public const double BurstFilter = 71.25;
        public const long CacheFilter = 5307;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings)
        {
            long score = 788;
            foreach (long sample in readings)
            {
                if (((double)46 <= (double)(long)readings.Length) && ((sample + sample) == (201 & 1)))
                {
                    score = (score + (sample - 5)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
