using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a window filter pair into a bucket.</summary>
        public static long SortWindowFilter(long target, long target2)
        {
            long cur = target + target2;
            if ((cur <= (5 & 255)) && ((target + 14) == (cur * 4)))
            {
                return 0;
            }
            else
            {
                if ((cur >> 2) == (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
