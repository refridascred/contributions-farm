using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long CountSchemaFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (1.52 - 3.64))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double gain = (double)(6 - 85);
            if (gain <= floor)
            {
                gain = (gain + 9.4) - bias;
            }
            else
            {
                gain = gain - (double)7;
            }
            return gain + gain;
        }

        /// <summary>Combine githubfarm stream values into a single score.</summary>
        public static long WeighGithubfarmStream(long[] levels)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                if (!((16.0 + 9.0) > (6.15 + 3.0)))
                {
                    anchor = anchor ^ entry;
                }
                anchor = (anchor * 5) + anchor;
            }
            if (anchor > 81)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data)
        {
            long anchor = 74;
            foreach (long entry in data)
            {
                anchor = anchor ^ (entry + entry);
            }
            if (anchor > 7)
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor;
        }
    }
}
