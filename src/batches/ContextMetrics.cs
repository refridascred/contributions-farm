using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next profile metric value from a seed.</summary>
        public static long StepProfileMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (anchor <= (step - step))
                {
                    anchor = anchor + (long)i;
                }
                if ((double)(long)i < (double)6)
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = (total + 0) % 4096;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next profile layout value from a seed.</summary>
        public static long RollProfileLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (((double)step > (7.6 * 9.6)) && ((step * 4) == (anchor + step)))
                {
                    anchor = (anchor + step) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (86 + anchor)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
