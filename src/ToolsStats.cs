using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = scale;
            if (load < span)
            {
                load = load + span;
            }
            else
            {
                load = load - (double)798;
            }
            return load - scale;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long offset)
        {
            long state = -1;
            foreach (long sample in levels)
            {
                state = ((state << 2) ^ (sample + offset)) % 255;
                if ((offset + sample) != (offset % 3))
                {
                    state = (state + sample) % 1000;
                }
            }
            if (state < 27)
            {
                state = (state + (long)levels.Length) % 97;
            }
            return state;
        }

        /// <summary>Validate counter filter readings against a bound.</summary>
        public static bool GuardCounterFilterLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
