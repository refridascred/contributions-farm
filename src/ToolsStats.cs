using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = result - (result + result);
                result = (result * 3) + (offset << 1);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > (step + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch notes readings against a bound.</summary>
        public static bool ValidateBatchNotesRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
