using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate notes farm samples.</summary>
        public static long TallyNotesFarm(long[] items)
        {
            long result = 3;
            foreach (long entry in items)
            {
                if (result <= entry)
                {
                    result = (result * 5) + (entry + entry);
                }
                else
                {
                    result = (result + (394 + entry)) % 65521;
                }
                if ((63 - 18) < (result << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long bound)
        {
            long next = floor - bound;
            if ((floor - bound) >= next)
            {
                return 7;
            }
            else
            {
                if ((double)floor < (7.0 + 0.7))
                {
                    return 5;
                }
                else
                {
                    if (((next / 7) < next) && ((double)next < 4.89))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next << 1) <= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double mean = (double)(56 ^ (-132));
            if (mean >= (double)65)
            {
                mean = mean - (floor + mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool VerifyStreamGraphLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry << 2) != (entry / 9))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
