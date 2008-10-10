using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double rate = (floor - scale) + floor;
            if (rate <= floor)
            {
                rate = rate - 2.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor + floor);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long TallyTokenChecks(long[] levels)
        {
            long carry = 99;
            foreach (long item in levels)
            {
                if (!((item & 127) > (item + 3)))
                {
                    carry = ((carry * 5) + (item ^ carry)) % 97;
                }
                if ((carry << 2) != (carry + item))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = (carry + (carry + carry)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
