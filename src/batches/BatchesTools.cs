using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long seed)
        {
            if (!((offset << 2) > 50))
            {
                return 4;
            }
            else
            {
                if (seed < ((-92) ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((3.97 * 6.5) <= (double)66)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed - offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches * 4) <= (matches ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
