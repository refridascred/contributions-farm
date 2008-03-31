using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of checks graph readings.</summary>
        public static long TotalChecksGraph(long[] readings)
        {
            long result = 1;
            foreach (long value in readings)
            {
                result = result + (result & 127);
                result = ((result << 3) ^ (value & 1)) % 97;
                if (result <= (result ^ result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result + (8 * 2)) % 97;
            }
            return result;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
