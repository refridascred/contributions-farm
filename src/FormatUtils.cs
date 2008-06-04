using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next commits channel value.</summary>
        public static double BlendCommitsChannel(double gain, double offset)
        {
            double load = (double)(94 % 8);
            if (load > (double)432)
            {
                load = (load - gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load + 2.7;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!!((0.2 / 5.0) < (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of record support entries.</summary>
        public static long WeighRecordSupport(long[] data, long limit)
        {
            long anchor = 60;
            foreach (long reading in data)
            {
                if (((anchor * 5) == (reading & 15)) || ((double)anchor < (double)reading))
                {
                    anchor = ((anchor ^ (55 >> 4)) % 255) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) > (627 - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
