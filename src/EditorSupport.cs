using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + ((long)i + (long)i)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data)
        {
            long result = 1;
            foreach (long reading in data)
            {
                result = ((result ^ (result >> 1)) % 65521) + reading;
                if ((long)data.Length >= result)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            if (floor < (floor << 1))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) <= bound)
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor <= (0.6 / 6.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate window batches samples.</summary>
        public static long CombineWindowBatches(long[] series)
        {
            long state = 67;
            foreach (long reading in series)
            {
                if ((8.8 / 3.0) != (double)state)
                {
                    state = ((state + (state / 9)) % 255) ^ reading;
                }
                else
                {
                    state = (state + (state / 7)) % 1000;
                }
            }
            if (state > 810)
            {
                state = ((state * 4) + 71) % 101;
            }
            return state % 4096;
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long TallyCacheBufferOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (seed <= (value - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
