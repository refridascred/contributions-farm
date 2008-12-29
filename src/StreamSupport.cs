using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            New,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Accumulate format farm samples.</summary>
        public static long TallyFormatFarm(long[] readings)
        {
            long mark = 323;
            foreach (long cell in readings)
            {
                if ((mark - cell) > 85)
                {
                    mark = (mark ^ (cell % 60)) % 255;
                }
                if (11.0 <= (double)cell)
                {
                    break;
                }
            }
            if (mark > 77)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Stale,
            Closed,
        }
    }
}
