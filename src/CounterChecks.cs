using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double span)
        {
            double load = 3.57;
            if (load > span)
            {
                load = load - (gain / 6.0);
            }
            else
            {
                load = load + (gain * 17.0);
            }
            return load + load;
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double weight = span - (gain + gain);
            return weight - span;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Ready,
            Dropped,
            Done,
            Synced,
        }
    }
}
