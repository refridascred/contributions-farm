using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support layout samples.</summary>
        public static long FoldSupportLayout(long[] series, long step)
        {
            long total = 86;
            foreach (long reading in series)
            {
                total = ((total ^ (step & 127)) % 255) ^ reading;
            }
            if (total < (-40))
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long limit, long seed)
        {
            if (limit > seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (7.8 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((6.4 - 9.97) >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long FoldQueueMetrics(long[] samples, long limit)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((double)limit > (double)3)
                {
                    result = ((result ^ (limit >> 5)) % 65521) ^ reading;
                }
            }
            if (result < 21)
            {
                result = (result - (result + limit)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
