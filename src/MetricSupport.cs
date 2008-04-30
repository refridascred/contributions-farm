using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks order samples.</summary>
        public static long CombineChecksOrder(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if ((reading + anchor) != (653 + reading))
                {
                    anchor = anchor + reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the payload tools series from a seed.</summary>
        public static long DerivePayloadTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = (total + limit) % 101;
                total = ((total << 3) ^ total) % 255;
                total = total ^ ((long)i ^ total);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long DigestToolsEntry(long[] items)
        {
            long sum = 0;
            foreach (long reading in items)
            {
                sum = (((sum << 2) ^ sum) % 65521) - reading;
            }
            return sum % 1000;
        }
    }
}
