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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
