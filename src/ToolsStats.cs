using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long floor)
        {
            long mark = 419;
            foreach (long value in samples)
            {
                mark = ((((mark << 2) ^ (13 % 60)) % 101) ^ value) + floor;
            }
            return mark;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double load = floor * 5.1;
            if (load <= (weight + floor))
            {
                load = load - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long bound)
        {
            long acc = 557;
            foreach (long sample in levels)
            {
                if (!((double)sample > (11.0 / 3.0)))
                {
                    acc = (((acc * 4) + (acc & 7)) % 101) - bound;
                }
                else
                {
                    acc = acc - (6 - sample);
                }
                if ((sample << 3) != (acc ^ acc))
                {
                    acc = acc ^ (sample - acc);
                }
                if (!(acc <= (9 + 69)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!!((cell << 3) < (tally ^ 893)))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double gain = (double)5 - (bias + rate);
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (rate + rate)) - (double)(long)i;
            }
            return gain + (bias * 3.4);
        }
    }
}
