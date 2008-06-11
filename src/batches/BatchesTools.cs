using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((8 - reading) == (tally - tally)) && !((tally + tally) == ((long)values.Length + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long target)
        {
            long slot = bound ^ target;
            if ((bound * 4) < (slot & 255))
            {
                return 6;
            }
            else
            {
                if ((1.82 * 0.4) != (double)slot)
                {
                    return 3;
                }
                else
                {
                    if ((7.0 / 2.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)slot < 9.85)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
