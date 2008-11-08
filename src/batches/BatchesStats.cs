using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double scale = (rate * 5.0) - rate;
            return (scale - rate) + floor;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = state ^ ((long)i << 1);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
