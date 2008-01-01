using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long seed)
        {
            long anchor = 78;
            foreach (long value in samples)
            {
                if ((value + anchor) >= seed)
                {
                    anchor = ((anchor << 3) ^ (51 >> 4)) % 4096;
                }
                else
                {
                    anchor = (anchor * 4) + (value >> 4);
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)origin == (double)(-20)) && ((double)origin == (3.6 - 7.72)))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double weight2 = span;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + (5.0 / 2.0)) + (double)(long)i) + weight;
            }
            return weight2 + span;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            New,
            Stale,
            Dropped,
        }
    }
}
