using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((span + 68) <= (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset) < offset2)
                {
                    return 3;
                }
                else
                {
                    if ((span + offset2) <= (span - offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset2 * 5) < (offset2 + (-32))) && ((span ^ offset2) != (95 - span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9008;
        public const long SoftLevel = 2214;
        public const string MinBudget = "latest";
        public const long HardBatch = 4120;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double load = scale * 20.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (scale * 6.2)) + (double)(long)i) + bias;
            }
            return load - (double)43;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
