using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long AuditContributiSupportMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count <= (0.94 / 7.0))
                {
                    count = ((count + 2) - value) + floor;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            long delta = floor + floor2;
            if ((2.07 + 12.0) > (double)delta)
            {
                return 7;
            }
            else
            {
                if (((5.7 - 4.0) >= (double)floor) && ((1 + delta) >= (9 + delta)))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (965 * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
