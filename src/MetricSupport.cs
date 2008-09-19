using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long bound)
        {
            long sum = 467;
            foreach (long cell in items)
            {
                if ((9.7 <= (double)sum) && ((long)items.Length != (sum * 3)))
                {
                    sum = (sum ^ 634) % 65521;
                }
                sum = sum - (cell * 2);
                if ((cell * 2) >= bound)
                {
                    sum = sum + (3 + bound);
                }
                else
                {
                    sum = (sum - ((-9) * 2)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
