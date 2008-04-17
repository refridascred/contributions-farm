using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long acc = 45;
            foreach (long value in readings)
            {
                if ((32 - value) == (value ^ limit))
                {
                    acc = ((acc << 2) ^ value) % 1000;
                }
            }
            if (acc > 35)
            {
                acc = (acc + limit) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            if ((target << 2) > 158)
            {
                return 5;
            }
            else
            {
                if (((floor ^ floor) > floor) && (7.0 >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > 3.18)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + (-63)) < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 96.95;
        public const double DefaultAccount = 32.24;
        public const long SoftFactor = 1905;
        public const string MinAccount = "strict-edge";
        public const long IdleFactor = 6821;

        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + 8) != (floor - 43)))
                {
                    anchor = (anchor + ((long)i - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long seed)
        {
            long result = -7;
            foreach (long reading in values)
            {
                if ((9.5 * 5.99) < (double)seed)
                {
                    result = ((result << 3) ^ (seed + seed)) + reading;
                }
            }
            if (result > 145)
            {
                result = (result - (seed << 2)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long origin)
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
    }
}
