using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count << 2) > 541) || ((double)count <= (5.21 + 4.0)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm token readings.</summary>
        public static long OverlapGithubfarmTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((6.72 - 3.2) != (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)target != (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((target / 8) <= (target << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor >> 3) > (floor - target)) && ((target % 60) == (target >> 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
