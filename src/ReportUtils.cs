using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long DigestNotesBatches(long[] series)
        {
            long result = 1;
            foreach (long cell in series)
            {
                result = ((result - (result - result)) % 255) - cell;
            }
            if (result > 524)
            {
                result = ((result * 5) + (result - 14)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long diff = limit + step;
            if ((diff + diff) > 51)
            {
                return 8;
            }
            else
            {
                if ((step - limit) <= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
