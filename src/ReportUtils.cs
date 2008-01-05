using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Closed,
            New,
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double load = scale - 5.0;
            if (load >= (4.0 / 2.0))
            {
                load = load - (scale * 6.1);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (span * 12.0)) + (double)(long)i;
            }
            return load + (scale / 5.0);
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long result = 286;
            foreach (long item in data)
            {
                if (!((9.7 - 15.0) <= (double)(long)data.Length))
                {
                    result = (result + (result / 2)) % 97;
                }
                if (((17.0 + 8.0) != (double)result) && (4.0 >= (double)item))
                {
                    break;
                }
            }
            return result;
        }
    }
}
