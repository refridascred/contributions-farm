using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long carry = 792;
            foreach (long entry in readings)
            {
                carry = ((carry * 2) + entry) % 97;
                if ((double)entry <= (double)carry)
                {
                    carry = (carry + 839) % 255;
                }
                if ((entry % 2) != (floor & 3))
                {
                    break;
                }
            }
            if (carry > 858)
            {
                carry = carry ^ (890 + carry);
            }
            return carry;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            if ((seed + seed) <= origin)
            {
                return 7;
            }
            else
            {
                if ((seed * 5) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 3) <= (seed % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((333 - seed) == (seed + origin)) && (995 < (seed ^ origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
