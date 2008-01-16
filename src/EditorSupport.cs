using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer stats value from a seed.</summary>
        public static long SeriesBufferStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long limit)
        {
            if (((offset - offset) < (offset + 924)) || (offset < (offset * 4)))
            {
                return 0;
            }
            else
            {
                if ((offset - 79) > 9)
                {
                    return 3;
                }
                else
                {
                    if ((offset / 9) < (offset + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((13.0 * 2.2) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools notes pairs that satisfy a relation.</summary>
        public static long PairToolsNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long AuditCommandFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < 7)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
