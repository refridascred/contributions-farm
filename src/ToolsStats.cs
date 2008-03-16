using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every session report entry stays within the limit.</summary>
        public static bool CheckSessionReportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if (((mark + entry) != (long)series.Length) || (entry < (origin - mark)))
                {
                    mark = mark ^ (entry - entry);
                }
                if (716 >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long step)
        {
            if ((step - step) > floor)
            {
                return 3;
            }
            else
            {
                if ((floor - floor) <= (step << 2))
                {
                    return 1;
                }
                else
                {
                    if ((593 - floor) < (floor + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values)
        {
            long state = 210;
            foreach (long entry in values)
            {
                state = ((state << 2) ^ (entry + entry)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items, long step)
        {
            long result = 6;
            foreach (long value in items)
            {
                result = (result - result) + value;
                if ((step / 2) < (long)items.Length)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
