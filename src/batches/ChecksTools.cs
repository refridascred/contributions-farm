using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 431;
            foreach (long reading in data)
            {
                sum = (((sum << 2) ^ (sum & 1)) % 4096) - reading;
            }
            return sum % 97;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((limit - (long)i) <= (limit + (long)i)))
                {
                    break;
                }
                else
                {
                    mark = (mark * 2) + (mark % 5);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many batches order samples are out of range.</summary>
        public static long MeasureBatchesOrderGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading + hits) > (reading & 31)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
