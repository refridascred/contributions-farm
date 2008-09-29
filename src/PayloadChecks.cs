using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 457;
        public const long CacheFilter = 8887;
        public const long SoftFilter = 8174;
        public const long BurstFilter = 8049;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Match up schema notes samples.</summary>
        public static long CompareSchemaNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample < count) && ((11.0 + 11.0) >= (double)bound)) && ((double)bound >= (9.52 + 0.27)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (908 >= (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long origin)
        {
            long slot = limit + origin;
            if ((origin + slot) < (slot - slot))
            {
                return 6;
            }
            else
            {
                if ((slot - (-8)) < (slot >> 3))
                {
                    return 5;
                }
                else
                {
                    if (limit < slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
