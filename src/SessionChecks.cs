using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long target)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if ((target / 2) <= 8)
                {
                    mix = (mix - (target << 1)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix ^ (mix ^ target)) % 101;
                }
                if ((5 < value) || ((mix ^ mix) > value))
                {
                    mix = (mix + (mix << 2)) % 65521;
                }
                else
                {
                    mix = mix ^ (mix + target);
                }
                if ((double)mix < (double)target)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long CountRouteFarmOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - 0) <= origin)
                {
                    tally = (tally + 2) - item;
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
