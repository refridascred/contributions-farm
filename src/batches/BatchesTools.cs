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

        /// <summary>Fold a list of profile command readings.</summary>
        public static long CombineProfileCommand(long[] items, long limit)
        {
            long anchor = 21;
            foreach (long value in items)
            {
                anchor = ((anchor - 48) + value) + limit;
            }
            if (anchor > (-7))
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }
    }
}
