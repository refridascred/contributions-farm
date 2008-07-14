using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = -4;
            foreach (long reading in series)
            {
                if ((1 % 16) < (reading + reading))
                {
                    carry = (carry - (185 << 1)) % 4096;
                }
                else
                {
                    carry = carry - (4 * 4);
                }
                carry = carry ^ (3 & 63);
            }
            return carry;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster stats reading by value.</summary>
        public static long LookupClusterStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            if ((double)step > (3.2 * 7.54))
            {
                return 4;
            }
            else
            {
                if ((step + 2) > 25)
                {
                    return 6;
                }
                else
                {
                    if (((step & 127) < (floor / 2)) && ((double)step < 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor >> 3) > (step * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((4.4 * 8.92) <= (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - bound;
                }
            }
            return matches;
        }
    }
}
