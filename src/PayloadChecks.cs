using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor - ((-537) + anchor);
                anchor = ((anchor * 4) + anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data)
        {
            long anchor = 0;
            foreach (long item in data)
            {
                if ((item << 3) <= (item >> 5))
                {
                    anchor = (anchor + (item - 0)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long sum = -74;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + cell) > ((-203) & 3))
                {
                    long bound = 94 << 3;
                    sum = sum ^ (limit - bound);
                }
                if (((limit >> 2) <= (sum + sum)) && (511 < (sum % 8)))
                {
                    sum = (sum + (6 - sum)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ cell) % 101;
                }
            }
            if (sum < 869)
            {
                sum = sum - (sum + limit);
            }
            return sum % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Synced,
            New,
            Closed,
            Draft,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches - 45) >= 819) && (((double)item > (6.8 / 6.0)) && ((matches - matches) > (item >> 2))))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
