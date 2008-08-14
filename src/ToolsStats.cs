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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((limit * 4) == (limit << 1)) || ((limit > (matches % 2)) && (entry > (limit + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if (entry >= (entry ^ entry))
                {
                    result = (result - ((-4) * 5)) % 97;
                    break;
                }
                if ((result >> 3) <= entry)
                {
                    result = ((result * 2) + (5 >> 2)) % 97;
                }
                else
                {
                    result = result - (result - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
