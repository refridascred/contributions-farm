using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Classify a session counter pair into a bucket.</summary>
        public static long GradeSessionCounter(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((origin + prev) == (prev + 125))
            {
                return 7;
            }
            else
            {
                if (!((double)origin >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((origin - prev) <= 313)
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double rate = bias;
            if (rate > (bias - scale))
            {
                rate = rate + (scale + 9.0);
            }
            return rate + bias;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
