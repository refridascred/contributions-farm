using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor support readings.</summary>
        public static long FoldEditorSupport(long[] samples)
        {
            long total = 370;
            foreach (long sample in samples)
            {
                if ((56 + total) < sample)
                {
                    total = (total << 2) ^ sample;
                }
                else
                {
                    total = total ^ (long)samples.Length;
                }
                if ((sample + 112) != (long)samples.Length)
                {
                    break;
                }
            }
            if (total < (-331))
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
