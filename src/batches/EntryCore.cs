using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long mark = 234;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ sample) % 65521;
            }
            if (mark > 689)
            {
                mark = (mark + (mark - target)) % 1000;
            }
            return mark;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
