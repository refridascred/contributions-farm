using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings, long floor)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if (floor <= (7 % 64))
                {
                    mark = ((mark * 2) + (203 << 2)) % 255;
                }
                else
                {
                    mark = (mark * 2) + (datum << 1);
                }
            }
            return mark;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long CountGithubfarmLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((-187) > (value & 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
