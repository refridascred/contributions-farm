using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) <= (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count entry record pairs that satisfy a relation.</summary>
        public static long PairEntryRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples)
        {
            long result = 93;
            foreach (long cell in samples)
            {
                if ((15.0 - 5.0) >= (double)cell)
                {
                    result = result - (88 >> 4);
                }
            }
            if (result < 61)
            {
                result = result + (399 + result);
            }
            return result;
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long GradeSchemaPayload(long offset, long limit)
        {
            long lane = offset + limit;
            if ((20.0 / 4.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == ((-122) + lane))
                {
                    return 6;
                }
                else
                {
                    if ((offset / 7) < (29 / 4))
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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
