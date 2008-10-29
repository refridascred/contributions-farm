using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next stream already value from a seed.</summary>
        public static long StepStreamAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target >> 1) != (result + 7))
                {
                    result = (result << 2) ^ (long)i;
                }
                else
                {
                    result = ((result * 2) + ((long)i - (long)i)) % 4096;
                }
                result = ((result * 4) + (result ^ result)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long target)
        {
            if ((target * 5) >= (offset / 9))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 7.5) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((target + 895) < 28))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((304 - reading) == (reading << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
