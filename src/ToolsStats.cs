using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up report already samples.</summary>
        public static long PairReportAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Digest a series of record notes entries.</summary>
        public static long WeighRecordNotes(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                if ((item ^ 619) < (28 + item))
                {
                    anchor = ((anchor << 3) ^ (item + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Locked,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                mark = ((mark << 2) ^ reading) % 1000;
            }
            if (mark > (-19))
            {
                mark = mark - ((-81) * 4);
            }
            return mark;
        }
    }
}
