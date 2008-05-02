using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long AuditStreamFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count & 31) > (count * 3))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + mix) % 65521) + reading;
            }
            if (mix < 35)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Paused,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Digest a series of commits queue entries.</summary>
        public static long TallyCommitsQueue(long[] series, long offset)
        {
            long anchor = 313;
            foreach (long reading in series)
            {
                if ((((long)series.Length * 4) > offset) && ((anchor - 8) >= (anchor + reading)))
                {
                    anchor = (anchor - (reading + anchor)) % 97;
                }
                if ((offset + 9) >= (anchor * 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
