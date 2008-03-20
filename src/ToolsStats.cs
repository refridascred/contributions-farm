using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches route reading.</summary>
        public static double ProjectBatchesRoute(double rate, double bias)
        {
            double bias2 = (rate + bias) - (bias / 5.0);
            if (bias2 < (bias2 * 2.17))
            {
                bias2 = bias2 - bias;
            }
            return bias2 - 0.12;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally / 9) != (sample << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double SmoothFilterEditor(double ratio, double floor)
        {
            double load = (floor / 2.0) + 4.9;
            if (load < floor)
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load + (floor / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((step + step) >= tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
