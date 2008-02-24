using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Count the editor route entries that pass the check.</summary>
        public static long MeasureEditorRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Paused,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (sum - sum)) % 65521) - (long)i;
                    sum = (sum - (sum >> 3)) % 65521;
                }
                sum = (sum << 2) ^ (cell % 64);
            }
            return sum;
        }
    }
}
