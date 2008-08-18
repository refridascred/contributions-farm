using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine order buffer values into a single score.</summary>
        public static long TallyOrderBuffer(long[] values, long target)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                if ((sum & 63) == (sum + sum))
                {
                    sum = (sum ^ (633 ^ sum)) + target;
                }
                else
                {
                    sum = ((sum << 3) ^ (372 + cell)) % 255;
                }
            }
            if (sum < 17)
            {
                sum = sum ^ (sum % 12);
            }
            return sum % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (hits + hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Locked,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of profile command readings.</summary>
        public static long WeighProfileCommand(long[] items)
        {
            long result = 63;
            foreach (long item in items)
            {
                result = (result - (item - result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
