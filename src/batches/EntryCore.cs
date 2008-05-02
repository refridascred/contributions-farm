using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a order batch sample.</summary>
        public static long FindOrderBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
