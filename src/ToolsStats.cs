using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = (score - (step + step)) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a stream account counter forward.</summary>
        public static long RollStreamAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (-416)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a account farm reading.</summary>
        public static double SmoothAccountFarm(double rate, double floor)
        {
            double drift = rate * 11.0;
            if (drift <= floor)
            {
                drift = drift - (rate - floor);
            }
            else
            {
                drift = drift - floor;
            }
            return drift - drift;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally == (double)1)
                {
                    tally = ((tally + 3) - cell) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
