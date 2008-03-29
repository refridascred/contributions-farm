using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long origin)
        {
            if (((8.7 - 4.33) == (double)limit) || ((double)limit <= (9.6 - 6.9)))
            {
                return 7;
            }
            else
            {
                if ((limit > (limit / 3)) && ((limit >> 3) <= limit))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >> 3) < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report entry readings against a rule.</summary>
        public static long AuditReportEntryOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample << 2) >= (sample + offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a context githubfarm counter forward.</summary>
        public static long SeriesContextGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry ^ 8) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first payload support entry that matches the target.</summary>
        public static long SeekPayloadSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
