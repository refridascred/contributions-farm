using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double scale = (double)(61 + 5);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (weight + 6.4)) + (double)(long)i) - span;
            }
            return scale + (double)553;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(cell >= (cell - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
