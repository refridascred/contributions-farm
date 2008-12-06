using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long floor)
        {
            if ((12.0 / 7.0) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((step << 2) < (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((floor / 3) <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor % 12) < (step / 6)) && ((double)81 > (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (span + 3.0)) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
