using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (158 > (offset + offset))
                {
                    result = result - ((-128) / 4);
                }
                else
                {
                    result = ((result << 3) ^ entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + offset) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long origin)
        {
            long gap = floor - origin;
            if ((5.25 * 9.1) != (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin * 2) <= (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if ((gap & 3) > (gap & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((6.0 / 5.0) == (double)gap))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Synced,
            Queued,
            Retry,
            Dropped,
        }
    }
}
