using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= ratio)
            {
                bias2 = bias2 - 4.0;
            }
            return bias2 - (double)2;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length << 3) > seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Rank graph batch input into a small class.</summary>
        public static long GradeGraphBatch(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (((lane + lane) != (limit >> 2)) || ((limit ^ lane) == (lane * 2)))
            {
                return 1;
            }
            else
            {
                if (!((lane ^ lane) >= (lane - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-12) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long TotalEditorCommand(long[] items, long bound)
        {
            long carry = 77;
            foreach (long cell in items)
            {
                carry = ((carry + (cell ^ (long)items.Length)) % 4096) + bound;
            }
            return carry;
        }
    }
}
