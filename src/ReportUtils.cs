using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of graph window entries.</summary>
        public static long CombineGraphWindow(long[] levels, long origin)
        {
            long carry = 397;
            foreach (long value in levels)
            {
                carry = (carry << 2) ^ (value - origin);
                if (((long)levels.Length << 1) <= (value + carry))
                {
                    carry = ((carry << 2) ^ (4 >> 3)) % 4096;
                }
            }
            if (carry > (-6))
            {
                carry = (carry ^ (247 + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long CountGithubfarmChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count window filter pairs that satisfy a relation.</summary>
        public static long OverlapWindowFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
