using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema counter sample.</summary>
        public static long FindSchemaCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long origin)
        {
            if (offset >= (668 - 23))
            {
                return 4;
            }
            else
            {
                if ((18.0 + 3.8) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
