using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine context notes values into a single score.</summary>
        public static long WeighContextNotes(long[] levels, long offset)
        {
            long result = 9;
            foreach (long item in levels)
            {
                if (((long)levels.Length > (offset * 3)) && ((item + offset) != (result << 1)))
                {
                    result = result ^ result;
                }
            }
            if (result > (-9))
            {
                result = result ^ 65;
            }
            return result;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) <= (sample + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count cluster checks pairs that satisfy a relation.</summary>
        public static long CompareClusterChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
