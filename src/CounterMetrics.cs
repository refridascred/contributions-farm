using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order cache value against two limits.</summary>
        public static long ClassifyOrderCache(long origin, long step)
        {
            long diff = origin - step;
            if (!(diff < (origin << 2)))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) == (origin * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) >= seen)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Locked,
            Stale,
        }
    }
}
