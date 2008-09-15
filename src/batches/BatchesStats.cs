using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count account route pairs that satisfy a relation.</summary>
        public static long PairAccountRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long next = offset ^ origin;
            if (next > offset)
            {
                return 7;
            }
            else
            {
                if (!((738 << 3) >= next))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + offset) >= (offset % 64)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin - offset) >= (offset + next)) || ((origin & 127) >= (origin + (-63))))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
