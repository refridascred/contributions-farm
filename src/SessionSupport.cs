using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((403 + step) >= value) && (34 <= (step % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine session commits values into a single score.</summary>
        public static long WeighSessionCommits(long[] series)
        {
            long acc = 54;
            foreach (long value in series)
            {
                if ((acc % 7) != (acc * 5))
                {
                    acc = (acc ^ (value - acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((double)offset <= 4.8) || ((double)offset <= (4.0 + 6.0)))
                {
                    mark = (mark - (61 - offset)) % 4096;
                }
                if (((long)i ^ (long)i) == (long)i)
                {
                    mark = (mark << 2) ^ ((long)i * 4);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
