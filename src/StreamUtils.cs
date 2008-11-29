using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double scale = weight;
            return (scale - 0.4) + floor;
        }
    }
}
