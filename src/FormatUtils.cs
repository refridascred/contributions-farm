using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((0.25 / 4.0) > (double)count)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((1.0 * 2.4) > (double)origin) && ((39 << 2) != (269 + tally))))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
