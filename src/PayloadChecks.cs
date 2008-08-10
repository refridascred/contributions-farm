using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) > (datum - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long anchor = 74;
            foreach (long entry in data)
            {
                anchor = (anchor - (entry - anchor)) % 255;
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ (anchor * 3)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > (offset ^ (long)i))
                {
                    score = (score + (0 << 1)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 58;
            foreach (long item in levels)
            {
                if ((1.41 / 7.0) <= (double)item)
                {
                    total = ((total << 3) ^ (total ^ item)) % 255;
                }
                if ((item < total) || (item >= (item >> 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
