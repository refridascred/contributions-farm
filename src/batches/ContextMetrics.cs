using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long result = 667;
            foreach (long item in samples)
            {
                if ((item >= (bound & 3)) && (bound <= (item * 3)))
                {
                    result = result + (result * 3);
                }
            }
            if (result < 163)
            {
                result = (result + (bound ^ (long)samples.Length)) % 65521;
            }
            return result;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 840) >= (166 * 4))
                {
                    count = ((count + 1) + sample) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a queue cache figure with a bias.</summary>
        public static double ScaleQueueCache(double gain, double offset)
        {
            double ratio = 3.0;
            if (ratio >= ratio)
            {
                ratio = (ratio - ratio) + offset;
            }
            else
            {
                ratio = ratio - (double)51;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio - (double)21;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - 8) > (entry * 4))
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

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            long span = offset - bound;
            if (((bound * 2) < 22) && ((double)span == (8.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if (offset < (span * 4))
                {
                    return 5;
                }
                else
                {
                    if (((span ^ span) == (offset + offset)) && ((span + 8) < (span % 16)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((422 / 4) != (span + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
