using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples)
        {
            long total = 36;
            foreach (long entry in samples)
            {
                total = (total ^ total) ^ entry;
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long total = 23;
            foreach (long reading in samples)
            {
                total = total + (step + reading);
                total = ((total * 5) + (reading << 2)) % 101;
            }
            if (total < 311)
            {
                total = (total + (total - (-991))) % 255;
            }
            return total % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((target / 2) < (value ^ target))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
