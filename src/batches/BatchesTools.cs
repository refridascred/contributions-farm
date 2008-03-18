using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine schema checks values into a single score.</summary>
        public static long WeighSchemaChecks(long[] data, long seed)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = (anchor - anchor) % 1000;
                if (!((seed ^ 3) < (reading >> 5)))
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
