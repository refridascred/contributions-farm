using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((long)data.Length <= seed))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 2) ^ (mark & 7);
                mark = ((mark * 4) + (seed >> 2)) % 255;
                if (((mark + seed) != (seed - seed)) || (((long)i ^ (long)i) == ((long)i - seed)))
                {
                    mark = (mark ^ (seed & 15)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Idle,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double mean = (double)583;
            if (mean < (12.0 * 2.45))
            {
                mean = mean + (double)538;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (weight + offset)) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
