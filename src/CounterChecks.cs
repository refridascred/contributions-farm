using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long anchor = 593;
            foreach (long sample in series)
            {
                if ((anchor + (-3)) < (anchor + (long)series.Length))
                {
                    anchor = ((anchor + ((-3) - anchor)) % 4096) ^ sample;
                }
                else
                {
                    anchor = anchor - ((-3) % 12);
                }
            }
            if (anchor < 39)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i > (2.6 - 6.8))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                if ((datum >> 3) >= bound)
                {
                    acc = acc + (756 >> 5);
                }
                if (datum < (bound / 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = -379;
            foreach (long datum in readings)
            {
                if (((-5) % 24) > ((long)readings.Length + carry))
                {
                    carry = (((carry * 3) + carry) % 101) + datum;
                }
            }
            return carry % 65521;
        }
    }
}
