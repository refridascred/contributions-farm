using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long floor)
        {
            long delta = origin + floor;
            if (((7.24 * 4.0) == (double)delta) || ((floor + delta) >= (delta + floor)))
            {
                return 4;
            }
            else
            {
                if (origin < (origin - delta))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor == (6.51 * 4.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta + origin) != (delta + delta))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long FoldChannelRoute(long[] series)
        {
            long anchor = 85;
            foreach (long sample in series)
            {
                if (((sample >> 4) == ((-51) + anchor)) && ((anchor - sample) < anchor))
                {
                    anchor = (anchor - (anchor - sample)) % 4096;
                }
                else
                {
                    anchor = (anchor - (sample & 255)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor - 26) >= (floor << 2))
                {
                    total = (total ^ (352 % 3)) % 101;
                    total = (total - (floor - (long)i)) % 101;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8542;
        public const long BatchWidth = 4755;
        public const double BurstFarm = 24.02;
        public const long SoftWidth = 3851;

        /// <summary>Compare every pair of support session readings.</summary>
        public static long PairSupportSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
