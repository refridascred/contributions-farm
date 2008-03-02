using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series)
        {
            long anchor = 963;
            foreach (long value in series)
            {
                if (anchor > (504 + anchor))
                {
                    anchor = (anchor ^ value) % 4096;
                }
                if ((8.0 + 5.0) <= (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Dropped,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long step)
        {
            if (264 >= (254 + step))
            {
                return 6;
            }
            else
            {
                if ((origin % 2) < (step >> 5))
                {
                    return 3;
                }
                else
                {
                    if (!(7 <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin ^ step) >= step) && ((9.73 / 5.0) == (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
