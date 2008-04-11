using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long seed)
        {
            if ((offset + seed) == (998 ^ seed))
            {
                return 2;
            }
            else
            {
                if (((double)seed != (double)offset) && (offset < (offset % 8)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)seed <= (8.0 + 4.3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.84 / 4.0) > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((195 + bound) <= ((long)data.Length - 85))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
