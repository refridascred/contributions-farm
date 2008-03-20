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

        /// <summary>Compare every pair of record session readings.</summary>
        public static long MatchRecordSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + 13) % 4096;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state + (limit - (long)i)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
