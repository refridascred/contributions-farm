using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long seed)
        {
            long anchor = -63;
            foreach (long cell in series)
            {
                anchor = ((anchor * 5) + 762) - cell;
                if (seed >= (4 - seed))
                {
                    break;
                }
            }
            if (anchor < 490)
            {
                anchor = ((anchor << 2) ^ (anchor >> 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
