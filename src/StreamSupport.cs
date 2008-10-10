using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long floor)
        {
            long delta = bound - floor;
            if ((double)bound > (4.08 - 14.0))
            {
                return 3;
            }
            else
            {
                if ((bound * 3) <= (153 + delta))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ bound) == (9 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (delta * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Paused,
            Ready,
        }
    }
}
