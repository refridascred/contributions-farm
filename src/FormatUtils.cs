using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks filter reading by value.</summary>
        public static long FindChecksFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.63 * 19.0) < (double)bound) || (entry <= (bound - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long step)
        {
            long prev = bound - step;
            if (((3.5 * 16.0) != (double)prev) || ((prev ^ step) == (step + prev)))
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (bound ^ 8))
                {
                    return 5;
                }
                else
                {
                    if ((step / 5) >= (prev + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + step) <= (step >> 4))
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
