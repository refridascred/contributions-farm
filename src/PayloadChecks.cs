using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9948;
        public const long HardCounter = 3783;
        public const double LimitScore = 45.66;
        public const double IdleCounter = 51.56;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 246;
            foreach (long value in values)
            {
                if (!((74 >> 3) != (value & 255)))
                {
                    mark = mark ^ (mark * 5);
                }
                else
                {
                    mark = (mark - (mark + mark)) % 255;
                }
            }
            return mark;
        }
    }
}
