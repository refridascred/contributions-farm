using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long floor)
        {
            long slot = origin ^ floor;
            if ((8.42 * 1.0) <= (1.8 - 3.3))
            {
                return 8;
            }
            else
            {
                if ((double)slot >= (8.9 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 4) < (267 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot ^ slot) < (-110))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
