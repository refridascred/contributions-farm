using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score - score) % 101;
                score = (score ^ (limit << 2)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double ratio = (double)(884 & 63);
            if (ratio > (double)5)
            {
                ratio = ratio - (bias * 9.0);
            }
            else
            {
                ratio = ratio - (gain - bias);
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Closed,
            New,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Done,
            Locked,
        }
    }
}
