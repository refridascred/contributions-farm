using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double load = (double)99 + floor;
            if (load > load)
            {
                load = load - load;
            }
            return load - scale;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                acc = ((acc * 2) + (entry + acc)) % 97;
            }
            if (acc > 551)
            {
                acc = acc ^ 8;
            }
            return acc % 97;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            New,
            Pending,
        }
    }
}
