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

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long limit)
        {
            long result = 39;
            foreach (long datum in data)
            {
                result = (result - (limit >> 5)) + datum;
            }
            return result % 65521;
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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
