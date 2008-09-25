using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits stream samples.</summary>
        public static long WeighCommitsStream(long[] values)
        {
            long result = 991;
            foreach (long datum in values)
            {
                if (result >= (datum - datum))
                {
                    result = (result << 2) ^ (36 + datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Synced,
            Paused,
        }
    }
}
