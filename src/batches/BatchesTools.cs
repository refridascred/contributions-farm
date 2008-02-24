using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many format schema samples are out of range.</summary>
        public static long MeasureFormatSchemaGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((6.33 - 5.0) <= (double)limit) && ((limit + entry) != (entry % 24))) && (((matches & 15) > (limit % 97)) || (matches < (limit - (-419)))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (step >= (anchor >> 4))
                {
                    anchor = anchor + step;
                }
                anchor = anchor - (6 + 155);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 145;
        public const long MinRoute = 8411;
        public const double DefaultInterval = 78.0;
        public const long LimitSize = 3243;
    }
}
