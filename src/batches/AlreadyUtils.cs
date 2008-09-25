using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if ((entry ^ mark) <= 16)
                {
                    mark = (mark + (mark >> 2)) % 101;
                }
            }
            if (mark < 7)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((1.6 / 2.0) < (double)sample)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
