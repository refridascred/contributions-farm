using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits format readings.</summary>
        public static long TallyCommitsFormat(long[] values, long seed)
        {
            long acc = 31;
            foreach (long reading in values)
            {
                if ((double)reading == (double)seed)
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (acc - 2)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long mark = 304;
            foreach (long datum in readings)
            {
                if (((mark % 24) != (datum - mark)) && ((datum ^ datum) >= (datum % 64)))
                {
                    mark = ((mark * 3) + (6 + (-28))) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
