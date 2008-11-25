using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long bound)
        {
            long next = origin + bound;
            if ((origin + next) < ((-4) - origin))
            {
                return 5;
            }
            else
            {
                if (origin > (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (origin * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 7) >= (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a report commits sample.</summary>
        public static long FindReportCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Roll a payload profile counter forward.</summary>
        public static long SeriesPayloadProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((203 << 2) < (sum & 3)) || ((17.0 + 7.25) == (double)offset))
                {
                    sum = (sum - (6 % 60)) % 4096;
                }
                else
                {
                    sum = sum - (sum - offset);
                    sum = sum ^ (7 >> 3);
                }
                sum = sum ^ (offset / 6);
                if (offset <= (sum % 16))
                {
                    sum = (sum ^ ((long)i % 16)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
