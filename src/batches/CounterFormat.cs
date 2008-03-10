using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum * 4) < 502))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Pending,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long result = 28;
            foreach (long sample in data)
            {
                result = result - (sample + 88);
                result = (result << 2) ^ (75 - result);
                if (sample >= result)
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
                if (((sample ^ result) <= sample) && ((result + result) >= (1 % 2)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
