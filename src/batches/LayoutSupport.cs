using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series, long step)
        {
            long acc = 766;
            foreach (long item in series)
            {
                if ((item + item) < (3 % 24))
                {
                    acc = ((acc + acc) % 1000) + step;
                }
            }
            return acc;
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Dropped,
            Retry,
            Pending,
            New,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
