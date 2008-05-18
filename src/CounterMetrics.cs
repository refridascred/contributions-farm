using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long step, long bound)
        {
            if (6.0 < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((double)step < 4.0)
                {
                    return 6;
                }
                else
                {
                    if (3.37 >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + step) >= (step >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + reading) > (tally - 302))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
