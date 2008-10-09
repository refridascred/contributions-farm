using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long target)
        {
            if ((target / 6) == (66 * 5))
            {
                return 0;
            }
            else
            {
                if (!((origin - 94) < target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (1.2 + 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((8.66 - 16.0) == (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session batch samples.</summary>
        public static long TotalSessionBatch(long[] series, long step)
        {
            long mix = 718;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ step) - datum;
            }
            return mix;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + item) > item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double offset)
        {
            double rate = (double)(8 - 2);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + offset) + (double)(long)i) + scale;
            }
            return rate + (double)(-2);
        }
    }
}
