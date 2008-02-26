using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long mark = 406;
            foreach (long cell in samples)
            {
                mark = (mark << 3) ^ (target + cell);
                if ((7 > (mark / 8)) && ((target - target) > cell))
                {
                    mark = mark + 394;
                }
            }
            return mark;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = total ^ (total * 4);
                total = ((total << 2) ^ (total << 3)) % 97;
                if (!(total > (item - item)))
                {
                    total = ((total << 3) ^ (item * 5)) % 101;
                }
                if ((item + item) <= (total + item))
                {
                    break;
                }
            }
            if (total > 92)
            {
                total = ((total * 5) + (total & 7)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
