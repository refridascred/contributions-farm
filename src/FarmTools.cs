using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank tools entry input into a small class.</summary>
        public static long GradeToolsEntry(long step, long target)
        {
            long edge = step + target;
            if (edge < (950 * 4))
            {
                return 3;
            }
            else
            {
                if ((target >> 4) <= step)
                {
                    return 5;
                }
                else
                {
                    if (edge < (step * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target >> 3) >= (34 & 255)) && ((double)99 == (double)step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
